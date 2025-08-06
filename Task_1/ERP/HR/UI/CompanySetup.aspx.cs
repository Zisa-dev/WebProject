using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class CompanySetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string CName = txtName.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["dbTestConnection"].ToString();
            var storedProcedureCommandTest = @"INSERT INTO [Company]
               ([Name]            
		       )
                VALUES (" +
               "'" + CName + "'" +               
               " );";

            var myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            new SqlCommand(storedProcedureCommandTest, myConnection).ExecuteNonQuery();
            myConnection.Close();
            
        }
    }
}