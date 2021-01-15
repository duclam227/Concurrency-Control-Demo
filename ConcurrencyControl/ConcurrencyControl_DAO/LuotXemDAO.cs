using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyControl_DAO
{
    public class LuotXemDAO : DBConnect
    {
        private static LuotXemDAO _instance = null;

        public static LuotXemDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LuotXemDAO();
                }

                return _instance;
            }
        }
<<<<<<< Updated upstream
=======

        public void AddViewing(string houseId, string cusId, string comment, DateTime date)
        {
            string command = $"exec Add_LuotXem '{date}', N'{comment}', '{houseId}', '{cusId}'";
            SqlCommand cmd = new SqlCommand(command, _conn);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void AddViewingFixed(string houseId, string cusId, string comment, DateTime date)
        {
            string command = $"exec themLuotXemFIXED '{date}', N'{comment}', '{houseId}', '{cusId}'";
            SqlCommand cmd = new SqlCommand(command, _conn);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void DeleteViewing(string id, DateTime date)
        {
            string command = $"exec xoaLuotXem '{id}', '{date}'";
            SqlCommand cmd = new SqlCommand(command, _conn);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void AddViewingWithoutWait(string houseID, string cusID, string comment, DateTime date)
        {
            string command = $"exec Add_LuotXem '{date}', N'{comment}', '{houseID}', '{cusID}'";
            SqlCommand cmd = new SqlCommand(command, _conn);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public Tuple<DataTable, int> GetViewingOfHouseFixed(string houseID)
        {
            DataTable data = new DataTable();
            string proc = "Get_SoLuotXemFixed";

            SqlCommand cmd = new SqlCommand(proc, _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //truyền biến vào
            cmd.Parameters.Add("@MANHA", SqlDbType.VarChar, 15).Value = houseID;
            cmd.Parameters.Add("@SOLUOTXEM", SqlDbType.Int).Direction = ParameterDirection.Output;

            _conn.Open();
            cmd.ExecuteNonQuery();


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            int amount = Convert.ToInt32(cmd.Parameters["@SOLUOTXEM"].Value);
            _conn.Close();

            Tuple<DataTable, int> result = new Tuple<DataTable, int>(data, amount);

            return result;
        }

        public Tuple<DataTable, int> GetViewingOfHouse(string houseID)
        {
            DataTable data = new DataTable();
            string proc = "Get_SoLuotXem";

            SqlCommand cmd = new SqlCommand(proc, _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //truyền biến vào
            cmd.Parameters.Add("@MANHA", SqlDbType.VarChar, 15).Value = houseID;
            cmd.Parameters.Add("@SOLUOTXEM", SqlDbType.Int).Direction = ParameterDirection.Output;

            _conn.Open();
            cmd.ExecuteNonQuery();


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            int amount = Convert.ToInt32(cmd.Parameters["@SOLUOTXEM"].Value);
            _conn.Close();

            Tuple<DataTable, int> result = new Tuple<DataTable, int>(data, amount);

            return result;
        }

        public Tuple<DataTable, int> GetViewingOfCustomerFixed(string id)
        {
            DataTable data = new DataTable();
            string proc = "xemTatCaLuotXemKHFixed";

            SqlCommand cmd = new SqlCommand(proc, _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //truyền biến vào
            cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 15).Value = id;
            cmd.Parameters.Add("@SoLuotXem", SqlDbType.Int).Direction = ParameterDirection.Output;

            _conn.Open();
            cmd.ExecuteNonQuery();


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            int amount = Convert.ToInt32(cmd.Parameters["@SoLuotXem"].Value);
            _conn.Close();

            Tuple<DataTable, int> result = new Tuple<DataTable, int>(data, amount);

            return result;
        }

        public Tuple<DataTable, int> GetViewingOfCustomer(string id)
        {
            DataTable data = new DataTable();
            string proc = "xemTatCaLuotXemKH";

            SqlCommand cmd = new SqlCommand(proc, _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //truyền biến vào
            cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 15).Value = id;
            cmd.Parameters.Add("@SoLuotXem", SqlDbType.Int).Direction = ParameterDirection.Output;

            _conn.Open();
            cmd.ExecuteNonQuery();


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            int amount = Convert.ToInt32(cmd.Parameters["@SoLuotXem"].Value);
            _conn.Close();

            Tuple<DataTable, int> result = new Tuple<DataTable, int>(data, amount);

            return result;
        }

        public DataTable See_View (string So, string Duong, string Phuong, string Quan, string TP)
        {
            DataTable result = new DataTable();

            string query = $"exec SEE_FEEDBACK N'{So}', N'{Duong}', N'{Phuong}', N'{Quan}', N'{TP}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);

            adapter.Fill(result);

            return result;
        }

        public DataTable See_View_Fixed(string So, string Duong, string Phuong, string Quan, string TP)
        {
            DataTable result = new DataTable();

            string query = $"exec SEE_FEEDBACK_FIXED N'{So}', N'{Duong}', N'{Phuong}', N'{Quan}', N'{TP}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);

            adapter.Fill(result);

            return result;
        }
>>>>>>> Stashed changes
    }
}
