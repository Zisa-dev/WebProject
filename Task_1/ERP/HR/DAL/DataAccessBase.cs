using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace HR.DAL
{
    public class DataAccessBase
    {
        public string ConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbERPConnection"].ToString();
            return connectionString;

        }
    }
}