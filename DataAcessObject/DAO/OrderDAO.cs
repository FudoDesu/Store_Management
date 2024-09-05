using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject.DAO
{
    public class OrderDAO : GenericDAO<Order>
    {
        public OrderDAO() { }
        public OrderDAO(StoreManagementContext context) => _context = context;
    }
}
