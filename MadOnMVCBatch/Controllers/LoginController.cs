using MadOnMVCBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MadOnMVCBatch.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        AuthorizationEntities db = new AuthorizationEntities();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDetail user)
        {
            var ValidUser = db.UserDetails.Where(s => s.UserName == user.UserName && s.Password == user.Password).SingleOrDefault();
            if(ValidUser!=null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Dashboard");
            }

            return View(user);
        }


        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }
        [Authorize(Roles="Admin")]
        public ActionResult ContactUs()
        {
            return View();
        }
        [Authorize(Roles = "Manager")]

        public ActionResult AboutUs()
        {
            return View();
        }
    }
}