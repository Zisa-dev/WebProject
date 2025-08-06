using HR.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class EmployeeInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                lblEmployeeName.Text = string.Empty;
                string employeeName = txtEmployeeName.Text;
                string employeeEmail = txtEmail.Text;
                string connectionString = ConfigurationManager.ConnectionStrings["dbERPConnection"].ToString();
                var sql = @"INSERT INTO [Employee]
               ([Name], [EmployeeEmail]
        
		       )
                VALUES (" +
                   "'" + employeeName + "'" +
                    ",'" + employeeEmail + "'" +
                   " );";
                EmployeeInformtionController objEmployeeInformtionController = new EmployeeInformtionController(); ;
                objEmployeeInformtionController.SaveEmployee(connectionString, sql);
               // SaveEmployee(connectionString, sql);
                lblEmployeeName.Text = "Data save successfully";
                ClearAll();

            }
            catch (Exception msgError)
            {

                lblEmployeeName.Text = msgError.ToString();
            }


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

        private void ClearAll()
        {
            txtEmployeeName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEmployeeID.Text = string.Empty;
        }

        protected void btnShowEmployee_Click(object sender, EventArgs e)

        {
            ShowEmployee();
        }

        private void ShowEmployee()
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
                grdEmployeeRecords.DataSource = dtEmployee;
                grdEmployeeRecords.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lblEmployeeName.Text = string.Empty;
                int employeeID = Convert.ToInt32( txtEmployeeID.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["dbERPConnection"].ToString();
                var sql = @"DELETE FROM Employee WHERE EmployeeID="+employeeID+"";
                SaveEmployee(connectionString, sql);
                lblEmployeeName.Text = "Data save successfully";
                ClearAll();
                ShowEmployee();
                

            }
            catch (Exception msgError)
            {

                lblEmployeeName.Text = msgError.ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                lblEmployeeName.Text = string.Empty;
                string employeeName = txtEmployeeName.Text;
                string employeeEmail = txtEmail.Text;
                int employeeID = Convert.ToInt32( txtEmployeeID.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["dbERPConnection"].ToString();
                var sql = @"UPDATE [Employee]
                           SET [Name] = '"+employeeName+"'"+
                              " ,[EmployeeEmail] = '"+employeeEmail+"'"+	       
                         " WHERE [EmployeeID] ="+employeeID+";";
                SaveEmployee(connectionString, sql);
                lblEmployeeName.Text = "Data save successfully";
                ClearAll();
                ShowEmployee();
                

            }
            catch (Exception msgError)
            {

                lblEmployeeName.Text = msgError.ToString();
            }
        }

        protected void grdEmployeeRecords_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int selectedIndex = Convert.ToInt32(e.CommandArgument.ToString());
                string employeeID = ((Label)grdEmployeeRecords.Rows[selectedIndex].FindControl("lblEmployeeID")).Text;
                
                if (e.CommandName.Equals("Select"))
                {
                    //string lblCountryID = ((Label)grdEmployeeRecords.Rows[selectedIndex].FindControl("lblCountryID")).Text;                   



                }
                else if (e.CommandName.Equals("Delete"))
                {
                    try
                    {
                        lblEmployeeName.Text = string.Empty;                        
                        string connectionString = ConfigurationManager.ConnectionStrings["dbERPConnection"].ToString();
                        var sql = @"DELETE FROM Employee WHERE EmployeeID=" + employeeID + "";
                        SaveEmployee(connectionString, sql);
                        lblEmployeeName.Text = "Data save successfully";                        
                        ShowEmployee();

                    }
                    catch (Exception msgError)
                    {

                        lblEmployeeName.Text = msgError.ToString();
                    }


                }

            }
            catch (Exception msgException)
            {
                lblEmployeeName.Text = msgException.Message;


            }

        }

        protected void grdEmployeeRecords_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}