using System;
using System.Collections.Generic;

namespace CafeWpfApp
{
    public partial class Table
    {
        public Table()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int Number { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
