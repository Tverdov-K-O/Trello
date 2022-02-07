using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<Entities.Table> Tables { get; set; }
        public DbSet<Entities.Desk> Desks { get; set; }

        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tverd\source\repos\Trello\DBFiles\DBTrello.mdf;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connString);

        }
    }
}
