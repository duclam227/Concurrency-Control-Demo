using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConcurrencyControl
{
    public partial class LostUpdate : Form
    {
        string connectionString = @"Data Source=CrazyloveH3720;Initial Catalog=QLBDS_11;" + "Integrated Security=true;";
        public LostUpdate()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //loai nha
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MALN FROM LOAINHA";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cbb_loainha.Items.Add(dr["MALN"].ToString());
                    cbb_loainha2.Items.Add(dr["MALN"].ToString());
                }

                //chi nhanh
                cmd.CommandText = "SELECT MACHINHANH FROM CHINHANH";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cbb_chinhanh.Items.Add(dr["MACHINHANH"].ToString());
                    cbb_chinhanh2.Items.Add(dr["MACHINHANH"].ToString());
                }

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM KHACHHANG", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                Tran1DataGridView.DataSource = dtbl;
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //them bi loi
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("InsertNewCustomer_bug", con))
                {
                    /*
                     *  @tenKH NVARCHAR(50), @diachiKH NVARCHAR(50),@sdtKH VARCHAR(12), 
                     *  @ngaysinh DATE, @gioitinh BIT, @nhucau BIT, @MALN VARCHAR(15),
	                 *  @tieuchi NVARCHAR(50), @machinhanh VARCHAR(15)
                     */
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@tenKH", SqlDbType.VarChar).Value = tb_name.Text;
                    cmd.Parameters.Add("@diachiKH", SqlDbType.VarChar).Value = tb_address.Text;
                    cmd.Parameters.Add("@sdtKH", SqlDbType.VarChar).Value = tb_phone.Text;
                    cmd.Parameters.Add("@ngaysinh", SqlDbType.VarChar).Value = dayofbitrh.Value.ToString("yyyy-MM-dd");
                    //sex
                    if(cbb_sex.SelectedItem.ToString() == "Nam")
                    {
                        cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 1;
                    }
                    else
                    {
                        cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 0;
                    }
                    cmd.Parameters.Add("@nhucau", SqlDbType.VarChar).Value = Int32.Parse(cbb_nhucau.SelectedItem.ToString());
                    cmd.Parameters.Add("@MALN", SqlDbType.VarChar).Value = cbb_loainha.SelectedItem.ToString();
                    cmd.Parameters.Add("@tieuchi", SqlDbType.VarChar).Value = tb_tieuchi.Text;
                    cmd.Parameters.Add("@machinhanh", SqlDbType.VarChar).Value = cbb_chinhanh.SelectedItem.ToString();

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("InsertNewCustomer_bug", con))
                {
                    /*
                     *  @tenKH NVARCHAR(50), @diachiKH NVARCHAR(50),@sdtKH VARCHAR(12), 
                     *  @ngaysinh DATE, @gioitinh BIT, @nhucau BIT, @MALN VARCHAR(15),
	                 *  @tieuchi NVARCHAR(50), @machinhanh VARCHAR(15)
                     */
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@tenKH", SqlDbType.VarChar).Value = tb_name2.Text;
                    cmd.Parameters.Add("@diachiKH", SqlDbType.VarChar).Value = tb_address2.Text;
                    cmd.Parameters.Add("@sdtKH", SqlDbType.VarChar).Value = tb_phone2.Text;
                    cmd.Parameters.Add("@ngaysinh", SqlDbType.VarChar).Value = dayofbitrh2.Value.ToString("yyyy-MM-dd");
                    //sex
                    if (cbb_sex2.SelectedItem.ToString() == "Nam")
                    {
                        cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 1;
                    }
                    else
                    {
                        cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 0;
                    }
                    cmd.Parameters.Add("@nhucau", SqlDbType.VarChar).Value = Int32.Parse(cbb_nhucau2.SelectedItem.ToString());
                    cmd.Parameters.Add("@MALN", SqlDbType.VarChar).Value = cbb_loainha2.SelectedItem.ToString();
                    cmd.Parameters.Add("@tieuchi", SqlDbType.VarChar).Value = tb_tieuchi2.Text;
                    cmd.Parameters.Add("@machinhanh", SqlDbType.VarChar).Value = cbb_chinhanh2.SelectedItem.ToString();

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //them bi loi
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("InsertNewCustomer", con))
                {
                    /*
                     *  @tenKH NVARCHAR(50), @diachiKH NVARCHAR(50),@sdtKH VARCHAR(12), 
                     *  @ngaysinh DATE, @gioitinh BIT, @nhucau BIT, @MALN VARCHAR(15),
	                 *  @tieuchi NVARCHAR(50), @machinhanh VARCHAR(15)
                     */
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@tenKH", SqlDbType.VarChar).Value = tb_name.Text;
                    cmd.Parameters.Add("@diachiKH", SqlDbType.VarChar).Value = tb_address.Text;
                    cmd.Parameters.Add("@sdtKH", SqlDbType.VarChar).Value = tb_phone.Text;
                    cmd.Parameters.Add("@ngaysinh", SqlDbType.VarChar).Value = dayofbitrh.Value.ToString("yyyy-MM-dd");
                    //sex
                    if (cbb_sex.SelectedItem.ToString() == "Nam")
                    {
                        cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 1;
                    }
                    else
                    {
                        cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 0;
                    }
                    cmd.Parameters.Add("@nhucau", SqlDbType.VarChar).Value = Int32.Parse(cbb_nhucau.SelectedItem.ToString());
                    cmd.Parameters.Add("@MALN", SqlDbType.VarChar).Value = cbb_loainha.SelectedItem.ToString();
                    cmd.Parameters.Add("@tieuchi", SqlDbType.VarChar).Value = tb_tieuchi.Text;
                    cmd.Parameters.Add("@machinhanh", SqlDbType.VarChar).Value = cbb_chinhanh.SelectedItem.ToString();

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("InsertNewCustomer", con))
                {
                    /*
                     *  @tenKH NVARCHAR(50), @diachiKH NVARCHAR(50),@sdtKH VARCHAR(12), 
                     *  @ngaysinh DATE, @gioitinh BIT, @nhucau BIT, @MALN VARCHAR(15),
	                 *  @tieuchi NVARCHAR(50), @machinhanh VARCHAR(15)
                     */
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@tenKH", SqlDbType.VarChar).Value = tb_name2.Text;
                    cmd.Parameters.Add("@diachiKH", SqlDbType.VarChar).Value = tb_address2.Text;
                    cmd.Parameters.Add("@sdtKH", SqlDbType.VarChar).Value = tb_phone2.Text;
                    cmd.Parameters.Add("@ngaysinh", SqlDbType.VarChar).Value = dayofbitrh2.Value.ToString("yyyy-MM-dd");
                    //sex
                    if (cbb_sex2.SelectedItem.ToString() == "Nam")
                    {
                        cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 1;
                    }
                    else
                    {
                        cmd.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = 0;
                    }
                    cmd.Parameters.Add("@nhucau", SqlDbType.VarChar).Value = Int32.Parse(cbb_nhucau2.SelectedItem.ToString());
                    cmd.Parameters.Add("@MALN", SqlDbType.VarChar).Value = cbb_loainha2.SelectedItem.ToString();
                    cmd.Parameters.Add("@tieuchi", SqlDbType.VarChar).Value = tb_tieuchi2.Text;
                    cmd.Parameters.Add("@machinhanh", SqlDbType.VarChar).Value = cbb_chinhanh2.SelectedItem.ToString();

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
