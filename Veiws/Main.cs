using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trello.Data;
using Trello.Entities;

namespace Trello
{
    public partial class Main : Form
    {
        AppDbContext _db = new AppDbContext();
        ListBox listBox;
        private Entities.Desk selectedDesk;
        private Entities.Table selectedTable;
        private Entities.Task selectedTask;
        public Main()
        {
            InitializeComponent();
            LoadDesks();
            SelectDesk();
            LoadTables();
            SelectTable();
        }
        private void SelectDesk()
        {
            if (tabControlDesk.TabPages.Count != 0)
            {
                foreach (var item in _db.Desks.Where(s => s.Name == tabControlDesk.SelectedTab.Text))
                {
                    selectedDesk = item;
                }
            }
        }
        private void SelectTable()
        {
            if (tabControlTable.TabPages.Count != 0)
            {
                foreach (var item in _db.Tables.Where(s => s.Name == tabControlTable.SelectedTab.Text && s.DeskId == selectedDesk.Id))
                {
                        selectedTable = item;
                }
            }
        }
        //Load
        private void LoadDesks()
        {
            tabControlDesk.TabPages.Clear();

            foreach (var item in _db.Desks)
            {
                tabControlDesk.TabPages.Add(item.ToString());
            }
            
        }
        private void LoadTables()
        {
            tabControlTable.TabPages.Clear();
            if (_db.Tables.Count() != 0)
            {
                foreach (var item in _db.Tables.Where(s => s.DeskId == selectedDesk.Id)
                    .OrderBy(s => s.Order)
                    .Include(e => e.Tasks))
                {
                    var newTabPage = new TabPage(item.ToString());
                    LoadTasks(newTabPage, item.Tasks);
                    tabControlTable.TabPages.Add(newTabPage);
                }
            }
        
        }
        private void LoadTasks(TabPage page, List<Entities.Task> tasks)
        {
            page.Controls.Clear();
            listBox = new ListBox();
            listBox.Items.AddRange(tasks.ToArray());
            page.Controls.Add(listBox);
            _db.SaveChanges();
        }


        private int OrderTable()
        {
            //try
            //{
                var tmp = _db.Tables.Where(s => s.DeskId == selectedDesk.Id).OrderBy(s => s.Order).LastOrDefault();
                if (tmp == null)
                    return 0;
                return tmp.Order + 10;
            //}
            //catch
            //{
            //    return 0;
            //}
        }
        //Create
        private void btnCreateDesk_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk
            {
                Id = Guid.NewGuid(),
                Name = textBoxCreateDesk.Text
            };
            _db.Desks.Add(desk);
            _db.SaveChanges();
            LoadDesks();
            LoadTables();
            textBoxCreateDesk.Text = "";
        }
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            SelectDesk();
            Entities.Table table = new Entities.Table
            {
                Id = Guid.NewGuid(),
                Name = textBoxCreateTable.Text,
                Desk = selectedDesk,
                Order = OrderTable()
            };
            _db.Tables.Add(table);
            _db.SaveChanges();
            LoadTables();
            textBoxCreateTable.Text = "";
        }
        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            Entities.Task task = new Entities.Task
            {
                Id = Guid.NewGuid(),
                Text = textBoxCreateTask.Text,
                Table = selectedTable
            };
            _db.Tasks.Add(task);
            _db.SaveChanges();
            var currentTasks = _db.Tasks.Where(s => s.Table.Id == selectedTable.Id).ToList();
            LoadTasks(tabControlTable.SelectedTab, currentTasks);
            textBoxCreateTask.Text = "";
        }
        //Delete
        private void btnDelDesk_Click(object sender, EventArgs e)
        {
            if (tabControlDesk.TabPages.Count != 0)
            {
                foreach (var item in _db.Desks)
                {
                    if (tabControlDesk.SelectedTab.Text == item.Name)
                    {
                        selectedDesk = item;
                    }
                }

                _db.Desks.Remove(selectedDesk);
                _db.SaveChanges();
                LoadDesks();
                
            }
        }
        //Changed
        private void tabControlTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDesk();
            SelectTable();
        }
        private void tabControlDesk_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDesk();
            SelectTable();
            LoadTables();
        }

        private void btnDelTask_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                _db.Tasks.Remove(listBox.SelectedItem as Entities.Task);
                _db.SaveChanges();
                LoadTables();
            }
        }

        private void btnDelTable_Click(object sender, EventArgs e)
        {
            if (tabControlTable.TabPages.Count != 0)
            {
                foreach (var item in _db.Tables)
                {
                    if (tabControlTable.SelectedTab.Text == item.Name)
                    {
                        selectedTable = item;
                    }
                }

                _db.Tables.Remove(selectedTable);
                _db.SaveChanges();
                LoadTables();
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            SelectDesk();
            SelectTable();
            if (_db.Tables.Count() != 0)
            {
                    selectedTask.Table = _db.Tables.Where(s => s.DeskId == selectedDesk.Id && s.Order == selectedTable.Order + 10)
                   .OrderBy(s => s.Order)
                   .Include(e => e.Tasks).Last();
            }
        }
    }
}

