using Core.Business;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Web.Controllers
{
    public class UserLoginController : Controller
    {
        private IUserLoginBusiness _userloginBusiness;
        public UserLoginController(IUserLoginBusiness userloginBusiness)
        {
            _userloginBusiness = userloginBusiness;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(UserLogin userlogin)
        {
            if (ModelState.IsValid)
            {
                var result = _userloginBusiness.AutenticacionUser(userlogin.Username, userlogin.Password);
                if (result.Count() >0)
                {
                    return RedirectToAction(nameof(UserProfileController.Index), "UserProfile");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }
            return View();
        }
    }
}
