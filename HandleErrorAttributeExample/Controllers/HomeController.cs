using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorAttributeExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HandleError]
        public ActionResult Index()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;

            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }
    }
}