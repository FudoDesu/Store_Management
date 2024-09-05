using System;
using System.Collections.Generic;

namespace BusinessObject.Entity
{
    public partial class User
    {
        public User()
        {
            Customers = new HashSet<Customer>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public int Status { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
