
namespace Trello
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCreateDesk = new System.Windows.Forms.TextBox();
            this.btnCreateDesk = new System.Windows.Forms.Button();
            this.tabControlDesk = new System.Windows.Forms.TabControl();
            this.tabPageDesk = new System.Windows.Forms.TabPage();
            this.tabControlTable = new System.Windows.Forms.TabControl();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.btnDelDesk = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBoxCreateTable = new System.Windows.Forms.TextBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.btnDelTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnDelTask = new System.Windows.Forms.Button();
            this.textBoxCreateTask = new System.Windows.Forms.TextBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.tabControlDesk.SuspendLayout();
            this.tabControlTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCreateDesk
            // 
            this.textBoxCreateDesk.Location = new System.Drawing.Point(47, 427);
            this.textBoxCreateDesk.Name = "textBoxCreateDesk";
            this.textBoxCreateDesk.Size = new System.Drawing.Size(119, 23);
            this.textBoxCreateDesk.TabIndex = 1;
            // 
            // btnCreateDesk
            // 
            this.btnCreateDesk.Location = new System.Drawing.Point(47, 456);
            this.btnCreateDesk.Name = "btnCreateDesk";
            this.btnCreateDesk.Size = new System.Drawing.Size(55, 23);
            this.btnCreateDesk.TabIndex = 2;
            this.btnCreateDesk.Text = "Create";
            this.btnCreateDesk.UseVisualStyleBackColor = true;
            this.btnCreateDesk.Click += new System.EventHandler(this.btnCreateDesk_Click);
            // 
            // tabControlDesk
            // 
            this.tabControlDesk.Controls.Add(this.tabPageDesk);
            this.tabControlDesk.Location = new System.Drawing.Point(0, 0);
            this.tabControlDesk.Name = "tabControlDesk";
            this.tabControlDesk.SelectedIndex = 0;
            this.tabControlDesk.Size = new System.Drawing.Size(797, 23);
            this.tabControlDesk.TabIndex = 4;
            this.tabControlDesk.SelectedIndexChanged += new System.EventHandler(this.tabControlDesk_SelectedIndexChanged);
            // 
            // tabPageDesk
            // 
            this.tabPageDesk.AutoScroll = true;
            this.tabPageDesk.BackColor = System.Drawing.Color.LightGray;
            this.tabPageDesk.Location = new System.Drawing.Point(4, 24);
            this.tabPageDesk.Name = "tabPageDesk";
            this.tabPageDesk.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesk.Size = new System.Drawing.Size(789, 0);
            this.tabPageDesk.TabIndex = 1;
            this.tabPageDesk.Text = "Desk   ";
            // 
            // tabControlTable
            // 
            this.tabControlTable.Controls.Add(this.tabPageTable);
            this.tabControlTable.Location = new System.Drawing.Point(0, 24);
            this.tabControlTable.Name = "tabControlTable";
            this.tabControlTable.SelectedIndex = 0;
            this.tabControlTable.Size = new System.Drawing.Size(797, 400);
            this.tabControlTable.TabIndex = 0;
            this.tabControlTable.SelectedIndexChanged += new System.EventHandler(this.tabControlTable_SelectedIndexChanged);
            // 
            // tabPageTable
            // 
            this.tabPageTable.AutoScroll = true;
            this.tabPageTable.BackColor = System.Drawing.Color.Silver;
            this.tabPageTable.Location = new System.Drawing.Point(4, 24);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(789, 372);
            this.tabPageTable.TabIndex = 0;
            this.tabPageTable.Text = "Table";
            // 
            // btnDelDesk
            // 
            this.btnDelDesk.Location = new System.Drawing.Point(108, 456);
            this.btnDelDesk.Name = "btnDelDesk";
            this.btnDelDesk.Size = new System.Drawing.Size(58, 23);
            this.btnDelDesk.TabIndex = 5;
            this.btnDelDesk.Text = "Delete";
            this.btnDelDesk.UseVisualStyleBackColor = true;
            this.btnDelDesk.Click += new System.EventHandler(this.btnDelDesk_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 492);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // textBoxCreateTable
            // 
            this.textBoxCreateTable.Location = new System.Drawing.Point(212, 430);
            this.textBoxCreateTable.Name = "textBoxCreateTable";
            this.textBoxCreateTable.Size = new System.Drawing.Size(119, 23);
            this.textBoxCreateTable.TabIndex = 7;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(212, 457);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(55, 23);
            this.btnCreateTable.TabIndex = 8;
            this.btnCreateTable.Text = "Create";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // btnDelTable
            // 
            this.btnDelTable.Location = new System.Drawing.Point(273, 457);
            this.btnDelTable.Name = "btnDelTable";
            this.btnDelTable.Size = new System.Drawing.Size(57, 23);
            this.btnDelTable.TabIndex = 9;
            this.btnDelTable.Text = "Delete";
            this.btnDelTable.UseVisualStyleBackColor = true;
            this.btnDelTable.Click += new System.EventHandler(this.btnDelTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Desk";
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(372, 459);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTask.TabIndex = 12;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // btnDelTask
            // 
            this.btnDelTask.Location = new System.Drawing.Point(463, 459);
            this.btnDelTask.Name = "btnDelTask";
            this.btnDelTask.Size = new System.Drawing.Size(75, 23);
            this.btnDelTask.TabIndex = 13;
            this.btnDelTask.Text = "Delete";
            this.btnDelTask.UseVisualStyleBackColor = true;
            this.btnDelTask.Click += new System.EventHandler(this.btnDelTask_Click);
            // 
            // textBoxCreateTask
            // 
            this.textBoxCreateTask.Location = new System.Drawing.Point(372, 430);
            this.textBoxCreateTask.Name = "textBoxCreateTask";
            this.textBoxCreateTask.Size = new System.Drawing.Size(166, 23);
            this.textBoxCreateTask.TabIndex = 14;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(337, 435);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(29, 15);
            this.labelTask.TabIndex = 15;
            this.labelTask.Text = "Task";
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(654, 429);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 16;
            this.btnMoveRight.Text = "→";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "MoveRight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "MoveLeft";
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(654, 459);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 19;
            this.btnMoveLeft.Text = "←";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.textBoxCreateTask);
            this.Controls.Add(this.btnDelTask);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.tabControlTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelTable);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.textBoxCreateTable);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnDelDesk);
            this.Controls.Add(this.tabControlDesk);
            this.Controls.Add(this.btnCreateDesk);
            this.Controls.Add(this.textBoxCreateDesk);
            this.Name = "Main";
            this.Text = "Trello";
            this.tabControlDesk.ResumeLayout(false);
            this.tabControlTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCreateDesk;
        private System.Windows.Forms.Button btnCreateDesk;
        private System.Windows.Forms.TabControl tabControlDesk;
        private System.Windows.Forms.TabPage tabPageDesk;
        private System.Windows.Forms.Button btnDelDesk;
        private System.Windows.Forms.TabControl tabControlTable;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBoxCreateTable;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnDelTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnDelTask;
        private System.Windows.Forms.TextBox textBoxCreateTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMoveLeft;
    }
}

