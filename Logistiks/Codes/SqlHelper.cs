using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Logistiks.Codes
{
    public class SqlHelper
    {
        SqlConnection cn;
        public SqlHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }
        public bool estConnecte
        {
            get
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
