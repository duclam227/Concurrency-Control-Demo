using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConcurrencyControl_DAO
{
    public class KhachHangDAO : DBConnect
    {
        private static KhachHangDAO _instance = null;

        public static KhachHangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhachHangDAO();
                }

                return _instance;
            }
        }

        public void AddNew(string name, string addr, string phone, string sex, DateTime dob, int nhucau, string maln, string tieuchi, string chinhanh)
        {
            SqlCommand cmd = new SqlCommand("InsertNewCustomer", _conn);

            cmd.CommandType = CommandType.StoredProcedure;

            /*
                *  @tenKH NVARCHAR(50), @diachiKH NVARCHAR(50),@sdtKH VARCHAR(12), 
                *  @ngaysinh DATE, @gioitinh BIT, @nhucau BIT, @MALN VARCHAR(15),
	            *  @tieuchi NVARCHAR(50), @machinhanh VARCHAR(15)
            */

            cmd.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@diachiKH", SqlDbType.NVarChar).Value = addr;
            cmd.Parameters.Add("@sdtKH", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = dob;
            //sex
            if (sex == "Nam")
            {
                cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 1;
            }
            else
            {
                cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 0;
            }
            cmd.Parameters.Add("@nhucau", SqlDbType.NVarChar).Value = nhucau;
            cmd.Parameters.Add("@MALN", SqlDbType.VarChar).Value = maln;
            cmd.Parameters.Add("@tieuchi", SqlDbType.NVarChar).Value = tieuchi;
            cmd.Parameters.Add("@machinhanh", SqlDbType.VarChar).Value = chinhanh;

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
           
        }

        public DataTable GetAll()
        {
            DataTable result = new DataTable();
            string query = "select * from KHACHHANG order by MAKH desc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);

            adapter.Fill(result);

            return result;
        }

        public void AddNewFixed(string name, string addr, string phone, string sex, DateTime dob, int nhucau, string maln, string tieuchi, string chinhanh)
        {
            SqlCommand cmd = new SqlCommand("InsertNewCustomer_FIX", _conn);

            cmd.CommandType = CommandType.StoredProcedure;

            /*
                *  @tenKH NVARCHAR(50), @diachiKH NVARCHAR(50),@sdtKH VARCHAR(12), 
                *  @ngaysinh DATE, @gioitinh BIT, @nhucau BIT, @MALN VARCHAR(15),
	            *  @tieuchi NVARCHAR(50), @machinhanh VARCHAR(15)
            */

            cmd.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@diachiKH", SqlDbType.NVarChar).Value = addr;
            cmd.Parameters.Add("@sdtKH", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = dob;
            //sex
            if (sex == "Nam")
            {
                cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 1;
            }
            else
            {
                cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 0;
            }
            cmd.Parameters.Add("@nhucau", SqlDbType.NVarChar).Value = nhucau;
            cmd.Parameters.Add("@MALN", SqlDbType.VarChar).Value = maln;
            cmd.Parameters.Add("@tieuchi", SqlDbType.NVarChar).Value = tieuchi;
            cmd.Parameters.Add("@machinhanh", SqlDbType.VarChar).Value = chinhanh;

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
