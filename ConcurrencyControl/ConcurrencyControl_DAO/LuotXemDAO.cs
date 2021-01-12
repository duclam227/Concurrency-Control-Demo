using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        public void AddViewing(string houseId, string cusId, string comment, DateTime date)
        {
            string command = $"exec themLuotXem '{date}', N'{comment}', '{houseId}', '{cusId}'";
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
    }
}
