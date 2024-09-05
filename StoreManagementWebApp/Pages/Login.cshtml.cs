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

namespace StoreManagementWebApp.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserRepository _user;

        public LoginModel(IUserRepository user)
        {
            _user = user;
        }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetInt32("role") != null)
            {
                return RedirectToPage("./ Index");
            }
            return Page();
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string Message { get; set; } = null;

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                var user = _user.Login(Email, Password);
                if (user == null)
                {
                    Message = "Wrong Email or Password!";
                    return Page();
                }
                else if (user.RoleId != null)
                {
                    if (user.RoleId == (int)RoleEnum.Admin)
                    {
                        HttpContext.Session.SetInt32("role", user.RoleId);
                        HttpContext.Session.SetString("user", "Admin");
                    }
                    else if (user.RoleId == (int)RoleEnum.Manager)
                    {
                        HttpContext.Session.SetInt32("role", user.RoleId);
                        HttpContext.Session.SetString("user", "Manager");
                    }
                    else if (user.RoleId == (int)RoleEnum.Staff)
                    {
                        HttpContext.Session.SetInt32("role", user.RoleId);
                        HttpContext.Session.SetString("user", "Staff");
                    }
                    else if (user.RoleId == (int)RoleEnum.Customer)
                    {
                        if (user.Status == (int)StatusEnum.Active)
                        {
                            HttpContext.Session.SetInt32("role", user.RoleId);
                            HttpContext.Session.SetString("user", user.UserName);
                        }
                        else if (user.Status == (int)StatusEnum.Inactive)
                        {
                            Message = "Your Account has been stop active. Please contact with Admin for more information";
                            return Page();
                        }
                        else if (user.Status == (int)StatusEnum.Banned)
                        {
                            Message = "Your Account has been banned by Admin. Please contact with Admin for more information";
                            return Page();
                        }
                    }
                    else
                    {
                        Message = "Your account is not verify to login. Please try again!";
                        return Page();
                    }
                }
            }
            catch (Exception ex)
            {
                Message = "Something wrong. Please try again!";
                Console.WriteLine(ex.Message);
                return Page();
            }
            return RedirectToPage("./Index");
        }
    }
}
