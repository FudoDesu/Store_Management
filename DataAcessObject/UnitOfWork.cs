using BusinessObject.Entity;
using DataAcessObject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject
{
    public class UnitOfWork
    {
        private static UnitOfWork instance;
        private static readonly object locker = new object();
        public static UnitOfWork Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new UnitOfWork();
                    }
                    return instance;
                }
            }
        }

        private CategoryDAO _categoryDAO;
        private CustomerDAO _customerDAO;
        private GroceryDAO _groceryDAO;
        private MembershipDAO _membershipDAO;
        private OrderDAO _orderDAO;
        private OrderDetailDAO _orderDetailDAO;
        private RoleDAO _roleDAO;
        private UserDAO _userDAO;

        private StoreManagementContext _context;

        public UnitOfWork()
        {
            _categoryDAO = new CategoryDAO();
            _customerDAO = new CustomerDAO();
            _groceryDAO = new GroceryDAO();
            _membershipDAO = new MembershipDAO();
            _orderDAO = new OrderDAO();
            _orderDetailDAO = new OrderDetailDAO();
            _roleDAO = new RoleDAO();
            _userDAO = new UserDAO();
        }

        public CategoryDAO CategoryDAO 
        { 
            get 
            { 
                return _categoryDAO ??= new CategoryDAO(_context);
            }
        }

        public CustomerDAO CustomerDAO
        {
            get
            {
                return _customerDAO ??= new CustomerDAO(_context);
            }
        }

        public GroceryDAO GroceryDAO
        {
            get
            {
                return _groceryDAO ??= new GroceryDAO(_context);
            }
        }

        public MembershipDAO MembershipDAO
        {
            get
            {
                return _membershipDAO ??= new MembershipDAO(_context);
            }
        }

        public OrderDAO OrderDAO
        {
            get
            {
                return _orderDAO ??= new OrderDAO(_context);
            }
        }

        public OrderDetailDAO OrderDetailDAO
        {
            get
            {
                return _orderDetailDAO ??= new OrderDetailDAO(_context);
            }
        }

        public RoleDAO RoleDAO
        {
            get
            {
                return _roleDAO ??= new RoleDAO(_context);
            }
        }

        public UserDAO UserDAO
        {
            get
            {
                return _userDAO ??= new UserDAO(_context);
            }
        }
    }
}
