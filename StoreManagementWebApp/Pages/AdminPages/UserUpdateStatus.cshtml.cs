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
    public class UserUpdateStatusModel : PageModel
    {
        private readonly IUserRepository _user;

        public UserUpdateStatusModel(IUserRepository user)
        {
            _user = user;
        }

        [BindProperty]
        public User User { get; set; } = default!;

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
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (User.Status == (int)StatusEnum.Active)
            {
                User.Status = (int)StatusEnum.Inactive;
            }
            else if (User.Status == (int)StatusEnum.Inactive)
            {
                User.Status = (int)StatusEnum.Active;
            }
            else if (User.Status == (int)StatusEnum.Banned)
            {
                User.Status = (int)StatusEnum.Active;
            }
            _user.Update(User);
            return RedirectToPage("./Index");
        }
    }
}
