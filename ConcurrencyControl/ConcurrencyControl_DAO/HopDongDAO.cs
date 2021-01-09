using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConcurrencyControl_DAO
{
    public class HopDongDAO : DBConnect
    {
        private static HopDongDAO _instance = null;

        public static HopDongDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HopDongDAO();
                }

                return _instance;
            }
        }

        public DataTable GetAllContracts()
        {
            DataTable result = new DataTable();

            string query = "select * from HopDong";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);

            adapter.Fill(result);

            return result;
        }
    }
}
