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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int result = db.SaveEmployee(emp);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Edit(int? id)
        {
           var Employee= db.GetEmployeeById(id);
            return View(Employee);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int result = db.UpdateEmployee(emp);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}