using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class DepartmentSetup : System.Web.UI.Page
    {
        private object txtDepartmentID;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
           string departmentName = txtDepartmentID.Text;
           //string connectionString = ConfigurationManager.ConnectionStrings["dbERPConnection"].ToString();

        }
    }
}