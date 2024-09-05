using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.Packaging;

namespace StoreManagementWebApp.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetInt32("role") != null)
            {
                HttpContext.Session.Remove("role");
            }

            if (HttpContext.Session.GetString("user") != null)
            {
                HttpContext.Session.Remove("user");

            }
            return RedirectToPage("./Login");
        }
    }
}
