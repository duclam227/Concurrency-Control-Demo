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

        public DataTable GetContractByID(string id)
        {
            DataTable result = new DataTable();

            string query = $"EXEC dbo.FIND_CONTRACT '{id}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);

            adapter.Fill(result);

            return result;
        }

        public DataTable GetEmployees()
        {
            DataTable dt = new DataTable();
            string query = "select MANV from NHANVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(dt);

            return dt;
        }

        public DataTable GetContractByIDFixed(string id)
        {
            DataTable result = new DataTable();

            string query = $"EXEC dbo.FIND_CONTRACT_FIX '{id}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);

            adapter.Fill(result);

            return result;
        }

        public void UpdateEndDate(string id, DateTime newDate)
        {
            string query = $"exec UpdateContractEndDate '{id}', '{newDate}'";

            SqlCommand cmd = new SqlCommand(query, _conn);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
