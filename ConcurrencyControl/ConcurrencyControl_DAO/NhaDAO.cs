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

        public DataTable GetAllHouses()
        {
            string query = "select * from Nha";
            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(data);

            return data;
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

        public void UpdateEndDate(string id, DateTime newDate)
        {
            string query = $"exec _Update_AD_Days '{id}', '{newDate}'";

            SqlCommand cmd = new SqlCommand(query, _conn);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public DataTable GetAHouseData(string id)
        {
            DataTable result = new DataTable();

            string query = $"exec Find_House '{id}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);

            adapter.Fill(result);

            return result;
        }

        public DataTable GetAHouseData_Fix(string id)
        {
            DataTable result = new DataTable();

            string query = $"exec Find_House_Fix '{id}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);

            adapter.Fill(result);

            return result;
        }

        public DataTable ShowListHouse()
        {
            DataTable result = new DataTable();
            string query = "SELECT* FROM dbo.NHA";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);

            adapter.Fill(result);

            return result;
        }

        public void Update_DL(string id, DateTime _newdate)
        {

            string query = $"exec dbo._Update_Ad_Days_DL '{id}', '{_newdate}'";
            SqlCommand cmd = new SqlCommand(query, _conn);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void Update_DL_Fix(string id, DateTime _newdate)
        {
            string query = $"EXEC  dbo._Update_Ad_Days_DL_Fix '{id}', '{_newdate}'";
            SqlCommand cmd = new SqlCommand(query, _conn);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();

        }

        public string SellHouse(string _id)
        {
            string _SDT = null;
            string query = "dbo.SELL_HOUSE";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNha", SqlDbType.VarChar, 15).Value = _id;
            cmd.Parameters.Add("@sdt", SqlDbType.VarChar, 15).Direction = ParameterDirection.Output;


            _conn.Open();
            cmd.ExecuteNonQuery();

            _SDT = Convert.ToString(cmd.Parameters["@sdt"].Value);
            _conn.Close();

            return _SDT;
        }
    }
}
