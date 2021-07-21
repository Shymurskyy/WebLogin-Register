using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLoginApp.Controllers
{
    public class RegisterController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessRegistration(UserModel userModel)
        {
            SecurityService security = new SecurityService();
            if (security.isValid(userModel))
            {
                return View("RegistrationFail",userModel);
            }
            if (security.registerSuccess(userModel))
            {
                return View("RegistrationSuccess", userModel);
            }
            else
                return View("RegistrationFail", userModel);
        }
    }
}
