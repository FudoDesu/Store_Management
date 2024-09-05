using System;
using System.Collections.Generic;

namespace BusinessObject.Entity
{
    public partial class Category
    {
        public Category()
        {
            Groceries = new HashSet<Grocery>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Grocery> Groceries { get; set; }
    }
}
