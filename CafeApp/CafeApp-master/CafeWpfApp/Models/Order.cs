using System;
using System.Collections.Generic;

namespace CafeWpfApp
{
    public partial class Order
    {
        public Order()
        {
            DishInOrders = new HashSet<DishInOrder>();
            DrinkInOrders = new HashSet<DrinkInOrder>();
            WorkedShifts = new HashSet<WorkedShift>();
        }

        public int Id { get; set; }
        public int? CountGuest { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? StatusOrderId { get; set; }
        public int? PaymentMethodId { get; set; }
        public int? TableId { get; set; }
        public int? UserId { get; set; }

        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual StatusOrder? StatusOrder { get; set; }
        public virtual Table? Table { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<DishInOrder> DishInOrders { get; set; }
        public virtual ICollection<DrinkInOrder> DrinkInOrders { get; set; }
        public virtual ICollection<WorkedShift> WorkedShifts { get; set; }
    }
}
