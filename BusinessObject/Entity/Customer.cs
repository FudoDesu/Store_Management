using System;
using System.Collections.Generic;

namespace BusinessObject.Entity
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public int MembershipId { get; set; }
        public double MembershipPoint { get; set; }

        public virtual Membership Membership { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
