using System;
using System.Collections.Generic;

namespace BusinessObject.Entity
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? GroceryId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double GroceryDiscountVoucherMoney { get; set; }
        public double FinalPrice { get; set; }

        public virtual Grocery? Grocery { get; set; }
        public virtual Order? Order { get; set; }
    }
}
