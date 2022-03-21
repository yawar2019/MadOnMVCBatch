using MadOnMVCBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MadOnMVCBatch.Controllers
{
    public class NewController : Controller
    {
        // GET: New Work is created on 21-03-2022
        public string Index()
        {
            return "india is Nos "+ Index2();
        }
        [NonAction]
        public int Index2()
        {
            return 1;
        }

        public ActionResult Index3()
        {
            return View();
        }

        public ActionResult Index4()
        {
            return View("Index3");
        }

        public string Index5(string id)//new/index5/45?name=james
        {
            return "My Employee Id is "+id+" & name is "+Request.QueryString["name"];
        }

        [Route("Airliness/Employees")]
        [Route("Hospital/Employees")]
        [Route("new/GetEmployee")]
        public ActionResult GetEmployee()
        {
            return View();
        }
        //domainName/Controller/ActionMethodName
        //localhost:3219/New/index

        public ActionResult SendDataToView()
        {
            ViewBag.Name ="Gaytri";
            return View();
        }
        //ViewBag is Dynamic property which is used to store any type of information as type is 
        //dynamic
        //it also help us to carry our information from controller to view
        

        public ActionResult SendDataToView2()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Gaytri";
            emp.EmpSalary = 234561;

            ViewBag.emp = emp;

            return View();
        }

        public ActionResult SendDataToView3()
        {
            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
            


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Gaytri";
            emp.EmpSalary = 234561;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Nidhi";
            emp1.EmpSalary = 98653;

            EmployeeModel emp3 = new EmployeeModel();
            emp3.EmpId = 3;
            emp3.EmpName = "srinivas";
            emp3.EmpSalary = 99653;


            EmployeeList.Add(emp);
            EmployeeList.Add(emp1);
            EmployeeList.Add(emp3);


            ViewBag.listemp = EmployeeList;
           

            return View();
        }

    }
}