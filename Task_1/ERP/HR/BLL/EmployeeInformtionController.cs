using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.BLL
{
    public class EmployeeInformtionController
    {
        public void SaveEmployee(string connectionString, string sql)
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
    }
}