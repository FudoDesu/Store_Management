using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject.DAO
{
    public class OrderDetailDAO : GenericDAO<OrderDetail>
    {
        public OrderDetailDAO() { }

        public OrderDetailDAO(StoreManagementContext context) => _context = context;
    }
}
