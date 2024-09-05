using BusinessObject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject.DAO
{
    public class UserDAO : GenericDAO<User>
    {
        public UserDAO() { }

        public UserDAO(StoreManagementContext context) => _context = context;

        public User Login (string email, string password)
        {
            var db = new StoreManagementContext();
            var user = db.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
            return user;
        }

        public async Task<User> LoginAsync(string email, string password)
        {
            var db = new StoreManagementContext();
            var user = await db.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
            return user;
        }

        public bool ValidateBeforeCreate(User user)
        {
            var db = new StoreManagementContext();
            var list = db.Users.ToList();
            foreach (var item in list)
            {
                if (item.Email == user.Email) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
