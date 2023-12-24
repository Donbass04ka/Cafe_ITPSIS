using System;
using System.Collections.Generic;

namespace CafeWpfApp
{
    public partial class StatusOrder
    {
        public StatusOrder()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
