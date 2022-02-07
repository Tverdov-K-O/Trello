using System;
using System.Collections.Generic;
using System.Text;

namespace Trello.Entities
{
    class Table
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DeskId { get; set; }
        public Desk Desk { get; set; }
        public int Order { get; set; }
        public List<Entities.Task> Tasks { get; set; } = new List<Entities.Task>();
        public override string ToString()
        {
            return this.Name;
        }
    }
}
