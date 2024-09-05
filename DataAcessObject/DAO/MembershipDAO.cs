using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject.DAO
{
    public class MembershipDAO : GenericDAO<Membership>
    {
        public MembershipDAO() { }
        public MembershipDAO(StoreManagementContext context) => _context = context;
    }
}
