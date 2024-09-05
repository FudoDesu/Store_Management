using BusinessObject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject.DAO
{
    public class CustomerDAO : GenericDAO<Customer>
    {
        public CustomerDAO() { }
        public CustomerDAO(StoreManagementContext context) => _context = context;

        public Customer GetByUserId(int userId)
        {
            var db = new StoreManagementContext();
            var user = db.Customers.FirstOrDefault(x => x.UserId == userId);
            return user;
        }

        public async Task<Customer> GetByUserIdAsync(int userId)
        {
            var db = new StoreManagementContext();
            var user = await db.Customers.FirstOrDefaultAsync(x => x.UserId == userId);
            return user;
        }
    }
}
