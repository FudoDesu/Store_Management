using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject.DAO
{
    public class CategoryDAO : GenericDAO<Category>
    {
        public CategoryDAO() { }
        public CategoryDAO(StoreManagementContext context) => _context = context;
    }
}
