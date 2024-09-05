using BusinessObject.Entity;
using BusinessObject.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject.DAO
{
    public class RoleDAO : GenericDAO<Role>
    {
        public RoleDAO() { }

        public RoleDAO(StoreManagementContext context) => _context = context;

        public List<Role> GetListForAdminModify()
        {
            var db = new StoreManagementContext();
            var list = db.Roles.Where(x => x.RoleId != (int)RoleEnum.Customer).ToList();
            return list;
        }
        
        public async Task<List<Role>> GetListForAdminModifyAsync()
        {
            var db = new StoreManagementContext();
            var list = await db.Roles.Where(x => x.RoleId != (int)RoleEnum.Customer).ToListAsync();
            return list;
        }


    }
}
