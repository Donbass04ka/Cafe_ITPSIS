using System;
using System.Collections.Generic;

namespace CafeWpfApp
{
    public partial class Drink
    {
        public Drink()
        {
            DrinkInOrders = new HashSet<DrinkInOrder>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<DrinkInOrder> DrinkInOrders { get; set; }
    }
}
