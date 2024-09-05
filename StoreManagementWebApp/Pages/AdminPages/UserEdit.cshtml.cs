using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Entity;
using RepositoryObject.Interface;
using BusinessObject.Enum;

namespace StoreManagementWebApp.Pages.AdminPages
{
    public class UserEditModel : PageModel
    {
        private readonly IUserRepository _user;
        private readonly IRoleRepository _role;

        public UserEditModel(IUserRepository user, IRoleRepository role)
        {
            _user = user;
            _role = role;
        }

        [BindProperty]
        public User User { get; set; } = default!;

        [BindProperty]
        public string Error { get; set; } = null;
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var user = _user.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            User = user;
            var listRole = _role.GetListForAdminModify();
            ViewData["RoleId"] = new SelectList(listRole, "RoleId", "RoleName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                _user.Update(User);
            }
            catch (Exception ex)
            {
                Error = "Update fail!";
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
