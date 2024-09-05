using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject.DAO
{
    public class GroceryDAO : GenericDAO<Grocery>
    {
        public GroceryDAO() { }
        public GroceryDAO(StoreManagementContext context) => _context = context;
    }
}
