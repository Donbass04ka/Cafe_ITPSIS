using System;
using System.Collections.Generic;

namespace CafeWpfApp
{
    public partial class Dish
    {
        public Dish()
        {
            DishInOrders = new HashSet<DishInOrder>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<DishInOrder> DishInOrders { get; set; }
    }
}
