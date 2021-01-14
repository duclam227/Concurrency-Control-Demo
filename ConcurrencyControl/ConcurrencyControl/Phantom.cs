using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConcurrencyControl_BUS;

namespace ConcurrencyControl
{
    public partial class Phantom : Form
    {
        public Phantom()
        {
            InitializeComponent();

            //load chủ nhà
            DataTable chuNha = NhaBUS.Instance.GetHouseOwners();
            foreach (DataRow dr in chuNha.Rows)
            {
                cbb_machunha.Items.Add(dr["Machunha"].ToString());
            }

            //load loại nhà
            DataTable houseTypes = NhaBUS.Instance.GetTypes();
            foreach (DataRow dr in houseTypes.Rows)
            {
                cbb_maloainha.Items.Add(dr["MALN"].ToString());
            }
        }

        private void AverageRentButton_Click(object sender, EventArgs e)
        {
            Tuple<DataTable, float, int> dt = NhaBUS.Instance.CalculateAverageRentPrice();

            DSNhaThueGridView.DataSource = dt.Item1;
            SLNhaThueLabel.Text = dt.Item2.ToString();
            AverageRentLabel.Text = dt.Item3.ToString();
        }

        private void AverageRentFixedButotn_Click(object sender, EventArgs e)
        {
            Tuple<DataTable, float, int> dt = NhaBUS.Instance.CalculateAverageRentPriceFixed();

            DSNhaThueGridView.DataSource = dt.Item1;
            SLNhaThueLabel.Text = dt.Item2.ToString();
            AverageRentLabel.Text = dt.Item3.ToString();
        }

        private void AddRentHouseButton_Click(object sender, EventArgs e)
        {
            /**
             * @MANHA varchar(15),@MALN varchar(15),@MACHUNHA varchar(15),@MANV varchar(15),@SlgPhong int,
						@TinhTrang bit,LoaiGiaoDich bit,@Gia float,
						@DieuKien nvarchar(50),@SoNha varchar(50),@Duong varchar(50),@Phuong varchar(50),
						@Quan varchar(50),@TP varchar(50),@NgayHetHan date
             */

            NhaBUS.Instance.AddHouse(tb_manha.Text, cbb_maloainha.SelectedItem.ToString(), cbb_machunha.SelectedItem.ToString(), int.Parse(tb_soluongphong.Text), int.Parse(tb_loaigiaodich.Text), float.Parse(tb_gia.Text), tb_dieukien.Text, tb_sonha.Text, tb_duong.Text, tb_phuong.Text, tb_quan.Text, tb_thanhpho.Text, ngayhethan.Value);
        }
    }
}
