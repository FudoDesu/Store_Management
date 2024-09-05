using System;
using System.Collections.Generic;

namespace BusinessObject.Entity
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public double TotalPrice { get; set; }
        public double MembershipDiscountMoney { get; set; }
        public double OrderDiscountVoucherMoney { get; set; }
        public double FinalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
