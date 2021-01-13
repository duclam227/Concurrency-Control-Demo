using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;

namespace ConcurrencyControl_DAO
{
    public class DBConnect 
    {
        static string connectionString = "Data Source=DESKTOP-0IA21OI;Initial Catalog=QLBDS_11;Integrated Security=True";
        protected SqlConnection _conn = new SqlConnection(connectionString);
    }
}
