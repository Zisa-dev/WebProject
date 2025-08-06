using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HR.Models;

namespace HR.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewEmployee(Employee objEmployee)
        {
            string employeeName = objEmployee.Name;
            string employeeEmail = objEmployee.Email;
            string connectionString = ConfigurationManager.ConnectionStrings["dbERPConnection"].ToString();
            var sql = @"INSERT INTO [Employee]
               ([Name], [EmployeeEmail]
        
		       )
                VALUES (" +
               "'" + employeeName + "'" +
                ",'" + employeeEmail + "'" +
               " );";

            SaveEmployee(connectionString, sql);
            return View();
        }
        private static void SaveEmployee(string connectionString, string sql)
        {
            try
            {
                var myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                new SqlCommand(sql, myConnection).ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception msgError)
            {

                throw msgError;
            }
        }

        public ActionResult ShowEmployee()
        {
            return View();
        }
        public ActionResult EmployeeRecords()
        {
            try
            {
                DataTable dtEmployee = new DataTable();
                dtEmployee = ShowEmployees();
                List<Employee> employees = new List<Employee>();
                foreach (DataRow rowNo in dtEmployee.Rows)
                {
                    Employee objEmployee = new Employee();
                    objEmployee.Name = rowNo["Name"].ToString();
                    objEmployee.Email = rowNo["EmployeeEmail"].ToString();
                    objEmployee.Id = Convert.ToInt32(rowNo["EmployeeID"].ToString());
                    employees.Add(objEmployee);
                }

                return View(employees);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }
        private DataTable ShowEmployees()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["dbERPConnection"].ToString();
                var sql = @"SELECT * FROM Employee";

                var myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                var myCommand = myConnection.CreateCommand();
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();


                var resultantDataAdapter = new SqlDataAdapter(myCommand);

                DataTable dtEmployee = new DataTable();
                resultantDataAdapter.Fill(dtEmployee);

                myConnection.Close();
                return dtEmployee;
            }
            catch (Exception)
            {
                throw;
            }
        }
            private DataTable ShowEmployees(int employeeID)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["dbERPConnection"].ToString();
                    var sql = @"SELECT * FROM Employee WHERE EmployeeID =" + employeeID + "";

                    var myConnection = new SqlConnection(connectionString);
                    myConnection.Open();

                    var myCommand = myConnection.CreateCommand();
                    myCommand.CommandText = sql;
                    myCommand.ExecuteNonQuery();


                    var resultantDataAdapter = new SqlDataAdapter(myCommand);

                    DataTable dtEmployee = new DataTable();
                    resultantDataAdapter.Fill(dtEmployee);

                    myConnection.Close();
                    return dtEmployee;
                }
                catch (Exception)
                {
                    throw;
                }

            }
            public ActionResult DeleteEmployee(int id)
            {
                try
                {
                    DataTable dtEmployee = new DataTable();
                    dtEmployee = ShowEmployees(id);
                    Employee objEmployee = new Employee();
                    foreach (DataRow item in dtEmployee.Rows)
                    {
                        objEmployee.Name = item["Name"].ToString();
                        objEmployee.Email = item["EmployeeEmail"].ToString();
                        objEmployee.Id = Convert.ToInt32(item["EmployeeID"].ToString());

                    }
                    return View(objEmployee);
                }
                catch (Exception msgException)
                {
                    throw msgException;
                }
            }
        [HttpPost]
        public ActionResult DeleteEmployee(Employee objEmployee)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["dbERPConnection"].ToString();
                var sql = @"DELETE FROM Employee WHERE EmployeeID=" + objEmployee.Id + "";
                SaveEmployee(connectionString, sql);
                return View();
            }
            catch (Exception msgException)
            {

                throw msgException;
            }
        }



    }
}

