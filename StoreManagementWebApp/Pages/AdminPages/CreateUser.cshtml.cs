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

namespace StoreManagementWebApp.Pages.AdminPages
{
    public class CreateUserModel : PageModel
    {
        private readonly IUserRepository _user;
        private readonly IRoleRepository _role;

        public CreateUserModel(IUserRepository user, IRoleRepository role)
        {
            _user = user;
            _role = role;
        }

        public IActionResult OnGet()
        {
            var listRole = _role.GetListForAdminModify();
            ViewData["RoleId"] = new SelectList(listRole, "RoleId", "RoleName");
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;
        [BindProperty]
        public string Error { get; set; } = null;
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (_user.ValidateBeforeCreate(User) == false)
            {
                Error = "User with this Email already exist!";
                return Page();
            }

            User.Status = (int)StatusEnum.Active;
            _user.Create(User);
            return RedirectToPage("./Index");
        }
    }
}
