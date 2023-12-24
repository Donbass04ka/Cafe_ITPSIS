using System;
using System.Collections.Generic;

namespace CafeWpfApp
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? Login { get; set; }
        public int? PostId { get; set; }
        public int? RoleId { get; set; }
        public string? Password { get; set; }

        public virtual Post? Post { get; set; }
        public virtual Role? Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
