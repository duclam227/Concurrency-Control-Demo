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
using System.Collections;

namespace ConcurrencyControl
{
    public partial class Phantom : Form
    {
        string connectionString = @"Data Source=CrazyloveH3720;Initial Catalog=QLBDS_11;" + "Integrated Security=true;";
        public Phantom()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //loai nha
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select MaLN from loainha";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cbb_maloainha.Items.Add(dr["MALN"].ToString());
                }

                //ma chu nha
                cmd.CommandText = "select Machunha from dbo.CHUNHA nha";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cbb_machunha.Items.Add(dr["Machunha"].ToString());
                }

                //ma nhan vien
                cmd.CommandText = "select manv from dbo.NHANVIEN ";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cbb_manhanvien.Items.Add(dr["manv"].ToString());
                }

                con.Close();
            }
        }

        private void Phantom_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /**
             * @MANHA varchar(15),@MALN varchar(15),@MACHUNHA varchar(15),@MANV varchar(15),@SlgPhong int,
						@TinhTrang bit,@SoLuotXem int,@LoaiGiaoDich bit,@Gia float,
						@DieuKien nvarchar(50),@SoNha varchar(50),@Duong varchar(50),@Phuong varchar(50),
						@Quan varchar(50),@TP varchar(50),@NgayDang date,@NgayHetHan date
             */
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertNewHome", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MANHA", SqlDbType.VarChar).Value = tb_manha.Text;
                    cmd.Parameters.Add("@MALN", SqlDbType.VarChar).Value = cbb_maloainha.SelectedItem.ToString();
                    cmd.Parameters.Add("@MACHUNHA", SqlDbType.VarChar).Value = cbb_machunha.SelectedItem.ToString();
                    cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = "1";
                    cmd.Parameters.Add("@SlgPhong", SqlDbType.VarChar).Value = Int32.Parse(tb_soluongphong.Text);
                    cmd.Parameters.Add("@TinhTrang", SqlDbType.VarChar).Value = Int32.Parse(tb_loaigiaodich.Text);
                    cmd.Parameters.Add("@SoLuotXem", SqlDbType.VarChar).Value = 0;
                    cmd.Parameters.Add("@LoaiGiaoDich", SqlDbType.VarChar).Value = Int32.Parse(tb_loaigiaodich.Text);
                    cmd.Parameters.Add("@Gia", SqlDbType.VarChar).Value = Int32.Parse(tb_gia.Text);
                    cmd.Parameters.Add("@DieuKien", SqlDbType.VarChar).Value = tb_dieukien.Text;
                    cmd.Parameters.Add("@SoNha", SqlDbType.VarChar).Value = tb_sonha.Text;
                    cmd.Parameters.Add("@Duong", SqlDbType.VarChar).Value = tb_duong.Text;
                    cmd.Parameters.Add("@Phuong", SqlDbType.VarChar).Value = tb_phuong.Text;
                    cmd.Parameters.Add("@Quan", SqlDbType.VarChar).Value = tb_quan.Text;
                    cmd.Parameters.Add("@TP", SqlDbType.VarChar).Value = tb_thanhpho.Text;
                    cmd.Parameters.Add("@NgayDang", SqlDbType.VarChar).Value = ngaydang.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@NgayHetHan", SqlDbType.VarChar).Value = ngayhethan.Value.ToString("yyyy-MM-dd");

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        private void cbb_machunha_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    con.Open();
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    string machunha = cbb_machunha.Text;
            //    cmd.CommandText = "select manha from Nha where tinhtrang = 1 and MaChuNha = '" + machunha + "'";
            //    cmd.ExecuteNonQuery();
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.Fill(dt);

            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        cbb_maloainha.Items.Add(dr["manha"].ToString());
            //    }
            //}   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_1.Text = "";
            tb_2.Text = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TinhTBGiaNhaThue_bug", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@lan1", SqlDbType.Float).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@lan2", SqlDbType.Float).Direction = ParameterDirection.Output;


                    cmd.ExecuteNonQuery();

                    tb_1.Text = cmd.Parameters["@lan1"].Value.ToString();
                    tb_2.Text = cmd.Parameters["@lan2"].Value.ToString();

                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //khong bị lỗi
            tb_1.Text = "";
            tb_2.Text = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TinhTBGiaNhaThue", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@lan1", SqlDbType.Float).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@lan2", SqlDbType.Float).Direction = ParameterDirection.Output;
                    

                    cmd.ExecuteNonQuery();

                    tb_1.Text = cmd.Parameters["@lan1"].Value.ToString();
                    tb_2.Text = cmd.Parameters["@lan2"].Value.ToString();

                    con.Close();
                }
            }    
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
