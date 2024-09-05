using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Entity;
using RepositoryObject.Interface;
using BusinessObject.Enum;

namespace StoreManagementWebApp.Pages.AdminPages
{
    public class UserDetailsModel : PageModel
    {
        private readonly IUserRepository _user;
        private readonly ICustomerRepository _customer;

        public UserDetailsModel(IUserRepository user, ICustomerRepository customer)
        {
            _user = user;
            _customer = customer;
        }

        public User User { get; set; } = default!;
        public Customer Customer { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var user = _user.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                User = user;
                if (User.RoleId == (int)RoleEnum.Customer)
                {
                    var customer = _customer.GetByUserId(User.UserId);
                    if (customer == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        Customer = customer;
                    }
                }
            }
            return Page();
        }
    }
}
