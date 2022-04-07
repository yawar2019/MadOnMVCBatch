using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Dapper;
namespace DapperExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

        public List<EmployeeModel> GetEmployees()
        {
            //SELECT * FROM [dbo].[employeeDetails]
            var result = con.Query<EmployeeModel>("sp_employee", commandType: CommandType.StoredProcedure).ToList();
            return result;
        }

        public int SaveEmployee(EmployeeModel emp)
        {
            var param = new DynamicParameters();
            param.Add("@EmpName", emp.EmpName);
            param.Add("@EmpSalary", emp.EmpSalary);

            int result = con.Execute("sp_CreateEmployee",param:param,commandType:CommandType.StoredProcedure);
            return result;
        }

        public EmployeeModel GetEmployeeById(int? id)
        {
            var param = new DynamicParameters();
            param.Add("@empid", id);

            var result = con.QuerySingleOrDefault<EmployeeModel>("spr_getEmployeeDetailsbyId", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }

        public int UpdateEmployee(EmployeeModel emp)
        {
            var param = new DynamicParameters();
            param.Add("@EmpId", emp.EmpId);
            param.Add("@EmpName", emp.EmpName);
            param.Add("@EmpSalary", emp.EmpSalary);

            int result = con.Execute("spr_updateEmployeeDetails", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }
        
        public int DeleteEmployee(int? id)
        {
            var param = new DynamicParameters();
            param.Add("@EmpId", id);
            int result = con.Execute("usp_DeleteEmployeeById", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }

    }
}