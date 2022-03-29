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
        // GET: New Work for vaishnavi is created on 21-03-2022
        public string Index()
        {
            return "india is Nos " + Index2();
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
            return "My Employee Id is " + id + " & name is " + Request.QueryString["name"];
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
            ViewBag.Name = "Gaytri";
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


        public ActionResult SendData()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Gaytri";
            emp.EmpSalary = 234561;


            // Object model = emp;

            return View(emp);
        }

        public ViewResult SendModelData5()
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


            DepartmentModel dept = new Models.DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";
            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Hr";


            EmployeeList.Add(emp);
            EmployeeList.Add(emp1);
            EmployeeList.Add(emp3);


            List<DepartmentModel> listdept = new List<DepartmentModel>();
            listdept.Add(dept);
            listdept.Add(dept1);


            EmpDept eobj = new EmpDept();
            eobj.emp = EmployeeList;
            eobj.dept = listdept;


            return View(eobj);
        }

        public RedirectResult GoToGoogle()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectResult SendModelData()
        {
            return Redirect("~/New/SendModelData5");//MVC URL
        }

        public ViewResult getMyPartialView()
        {
            return View();
        }

        public ViewResult getMyPartialView2()
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


            DepartmentModel dept = new Models.DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";
            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Hr";


            EmployeeList.Add(emp);
            EmployeeList.Add(emp1);
            EmployeeList.Add(emp3);


            List<DepartmentModel> listdept = new List<DepartmentModel>();
            listdept.Add(dept);
            listdept.Add(dept1);


            EmpDept eobj = new EmpDept();
            eobj.emp = EmployeeList;
            eobj.dept = listdept;


            return View(eobj);
        }

        public FileResult GetMeFile()
        {
            return File("~/Web.config", "text");
        }

        public FileResult GetMeFile2()
        {
            return File("~/Web.config", "application/xml", "Web.config");
        }

        public FileResult GetMeFile3()
        {
            return File("~/ActionResult.pdf", "application/pdf", "nidhi");
        }

        public JsonResult GetMeJsonInfo()
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


            DepartmentModel dept = new Models.DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";
            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Hr";


            EmployeeList.Add(emp);
            EmployeeList.Add(emp1);
            EmployeeList.Add(emp3);


            List<DepartmentModel> listdept = new List<DepartmentModel>();
            listdept.Add(dept);
            listdept.Add(dept1);


            EmpDept eobj = new EmpDept();
            eobj.emp = EmployeeList;
            eobj.dept = listdept;

            return Json(eobj, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetJson(int ? id)
        {
            EmployeeModel emp3 = new EmployeeModel();
            emp3.EmpId = 3;
            emp3.EmpName = "srinivas";
            emp3.EmpSalary = 99653;
            return Json(emp3, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetJson2(EmployeeModel emp)
        {
            EmployeeModel emp3 = new EmployeeModel();
            emp3.EmpId = 3;
            emp3.EmpName = "srinivas";
            emp3.EmpSalary = 99653;
            return Json(emp3, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetJsonResultView()
        {
            return View();
        }

        public RedirectToRouteResult  getRediectToAction()
        {
            return RedirectToAction("GetJson","New",new { id = 1 });
        }

        public RedirectToRouteResult getRediectToAction2()
        {
            EmployeeModel emp3 = new EmployeeModel();
            emp3.EmpId = 3;
            emp3.EmpName = "jawahar";
            emp3.EmpSalary = 99653;


            return RedirectToAction("GetJson2", "New", emp3);
        }

        public RedirectToRouteResult getRediectToAction4()
        {
           
            return RedirectToRoute("Nidhi");
        }
    }
}