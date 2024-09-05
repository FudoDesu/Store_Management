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
    public class IndexModel : PageModel
    {
        private readonly IUserRepository _user;
        private readonly IRoleRepository _role;
        public IndexModel(IUserRepository user, IRoleRepository role)
        {
            _user = user;
            _role = role;
        }

        public IList<User> User { get;set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            if (HttpContext.Session.GetInt32("role") != (int)RoleEnum.Admin)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                User = _user.GetList();
                foreach (var user in User)
                {
                    var role = _role.GetById(user.RoleId);
                    user.Role = role;
                }
                return Page();
            }
        }
    }
}
