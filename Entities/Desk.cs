using System;
using System.Collections.Generic;
using System.Text;

namespace Trello.Entities
{
    class Desk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Entities.Table> Tables { get; set; }
        public override string ToString()
        {
            return this.Name;
        }

    }
}
