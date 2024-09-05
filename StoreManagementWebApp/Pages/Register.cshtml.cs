using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObject.Entity;
using RepositoryObject.Interface;
using BusinessObject.Enum;
using System.Runtime.CompilerServices;

namespace StoreManagementWebApp.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IUserRepository _user;
        private readonly ICustomerRepository _customer;

        public RegisterModel(IUserRepository user, ICustomerRepository customer)
        {
            _user = user;
            _customer = customer;
        }

        IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;
        [BindProperty]
        public string ConfirmPassword { get; set; }
        [BindProperty]
        public string Message { get; set; } = null;
        [BindProperty]
        public string Error { get; set; } = null;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (User.Password != ConfirmPassword)
                {
                    Error = "Confirm Password is not match. Please try again!";
                    return Page();
                }

                User.RoleId = (int)RoleEnum.Customer;
                User.Status = (int)StatusEnum.Active;

                _user.Create(User);

                var customer = new Customer
                {
                    UserId = User.UserId,
                    MembershipId = (int)MembershipEnum.Standard,
                    MembershipPoint = 0,
                };

                _customer.Create(customer);

                Message = "Regist Account Success! Returning to Login...";
                return RedirectToPage("./Login");
            }
            catch (Exception ex)
            {
                Error = "Register new account fail!!!";
                Console.WriteLine(ex.Message);
                return Page();
            }
        }
    }
}
