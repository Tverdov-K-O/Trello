using System;
using System.Collections.Generic;
using System.Text;

namespace Trello.Entities
{
    class Task
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid TableId { get; set; }
        public Table Table { get; set; }
        public override string ToString()
        {
            return this.Text;
        }
    }
}
