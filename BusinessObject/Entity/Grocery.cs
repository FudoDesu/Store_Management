using System;
using System.Collections.Generic;

namespace BusinessObject.Entity
{
    public partial class Grocery
    {
        public Grocery()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int GroceryId { get; set; }
        public int CategoryId { get; set; }
        public string GroceryName { get; set; } = null!;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
