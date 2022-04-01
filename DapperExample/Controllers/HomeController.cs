using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DapperExample.Models;
namespace DapperExample.Controllers
{
    public class HomeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.GetEmployees());
        }
    }
}