using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorExample2.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
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

       
        public ActionResult Index2()
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