using System;
using System.Collections.Generic;

namespace CafeWpfApp
{
    public partial class DrinkInOrder
    {
        public int Id { get; set; }
        public int? DrinkCount { get; set; }
        public int? DrinkId { get; set; }
        public int? OrderId { get; set; }

        public virtual Drink? Drink { get; set; }
        public virtual Order? Order { get; set; }
    }
}
