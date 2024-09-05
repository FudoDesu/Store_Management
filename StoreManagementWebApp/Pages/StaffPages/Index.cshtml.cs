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

namespace StoreManagementWebApp.Pages.StaffPages
{
    public class IndexModel : PageModel
    {
        private readonly IGroceryRepository _grocery;

        public IndexModel(IGroceryRepository grocery)
        {
            _grocery = grocery;
        }

        public IList<Grocery> Grocery { get;set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            if (HttpContext.Session.GetInt32("role") != (int)RoleEnum.Staff)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Grocery = _grocery.GetList();
                return Page();
            }
        }
    }
}
