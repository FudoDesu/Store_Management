using BusinessObject.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StoreManagementWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetInt32("role") == (int)RoleEnum.Admin)
            {
                return RedirectToPage("/AdminPages/Index");
            }
            else if (HttpContext.Session.GetInt32("role") == (int)RoleEnum.Manager)
            {
                return RedirectToPage("/ManagerPages/Index");
            }
            else if (HttpContext.Session.GetInt32("role") == (int)RoleEnum.Staff)
            {
                return RedirectToPage("/StaffPages/Index");
            }
            else if (HttpContext.Session.GetInt32("role") == (int)RoleEnum.Customer)
            {
                return RedirectToPage("/CustomerPages/Index");
            }
            else
            {
                return RedirectToPage("./Login");
            }
        }
    }
}