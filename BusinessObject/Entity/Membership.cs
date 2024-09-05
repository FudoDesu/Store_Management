using System;
using System.Collections.Generic;

namespace BusinessObject.Entity
{
    public partial class Membership
    {
        public Membership()
        {
            Customers = new HashSet<Customer>();
        }

        public int MembershipId { get; set; }
        public string MembershipName { get; set; } = null!;
        public int MembershipPoint { get; set; }
        public int MembershipDiscount { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
