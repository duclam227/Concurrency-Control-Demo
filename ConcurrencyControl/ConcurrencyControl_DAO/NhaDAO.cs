using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConcurrencyControl_DAO
{
    public class NhaDAO : DBConnect
    {
        private static NhaDAO _instance = null;

        public static NhaDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NhaDAO();
                }

                return _instance;
            }
        }

        public Tuple<DataTable, int> GetSellingHouses(DateTime date)
        {
            DataTable data = new DataTable();
            string proc = "GetAmountOfSellingHouses";

            SqlCommand cmd = new SqlCommand(proc, _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //truyền biến vào
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Direction = ParameterDirection.Output;

            _conn.Open();
            cmd.ExecuteNonQuery();
            

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;

            adapter.Fill(data);
            
            int amount = Convert.ToInt32(cmd.Parameters["@amount"].Value);
            _conn.Close();

            Tuple<DataTable, int> result = new Tuple<DataTable, int>(data, amount);

            return result;
        }

        public Tuple<DataTable, int> GetSellingHousesFixed(DateTime date)
        {
            DataTable data = new DataTable();
            string proc = "GetAmountOfSellingHouses_Fix";

            SqlCommand cmd = new SqlCommand(proc, _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //truyền biến vào
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Direction = ParameterDirection.Output;

            _conn.Open();
            cmd.ExecuteNonQuery();


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            int amount = Convert.ToInt32(cmd.Parameters["@amount"].Value);
            _conn.Close();

            Tuple<DataTable, int> result = new Tuple<DataTable, int>(data, amount);

            return result;
        }

        public void ChangeToRent(string id)
        {
            string command = $"exec dbo.SetHouseToRenting '{id}'";
            SqlCommand cmd = new SqlCommand(command, _conn);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
