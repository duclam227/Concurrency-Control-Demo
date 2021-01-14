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
    public partial class LostUpdate : Form
    {
        public LostUpdate()
        {
            InitializeComponent();

            CustomerIDTextBox.Text = "02";

            //load loại nhà
            DataTable houseTypes = NhaBUS.Instance.GetTypes();
            foreach (DataRow dr in houseTypes.Rows)
            {
                cbb_loainha.Items.Add(dr["MALN"].ToString());
            }

            //load chi nhánh
            DataTable branch = NhaBUS.Instance.GetBranches();
            foreach (DataRow dr in branch.Rows)
            {
                cbb_chinhanh.Items.Add(dr["MACHINHANH"].ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable data = NhaBUS.Instance.GetAllHouses();

            HouseDataGridView.DataSource = data;
        }

        private void AddWatchButton_Click(object sender, EventArgs e)
        {
            string houseId = HouseIDTextBox.Text;
            string cusId = CustomerIDTextBox.Text;
            string comment = CommentTextBox.Text;
            DateTime date = dateTimePicker.Value;

            LuotXemBUS.Instance.AddViewing(houseId, cusId, comment, date);

        }

        private void AddWatchFixedButton_Click(object sender, EventArgs e)
        {
            string houseId = HouseIDTextBox.Text;
            string cusId = CustomerIDTextBox.Text;
            string comment = CommentTextBox.Text;
            DateTime date = dateTimePicker.Value;

            LuotXemBUS.Instance.AddViewingFixed(houseId, cusId, comment, date);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //them bi loi
            string name = tb_name.Text;
            string addr = tb_address.Text;
            string phone = tb_phone.Text;
            string tieuchi = tb_tieuchi.Text;
            DateTime dob = dayofbitrh.Value;
            string sex = cbb_chinhanh.SelectedItem.ToString();
            int nhucau = int.Parse(cbb_nhucau.SelectedItem.ToString());
            string maln = cbb_loainha.SelectedItem.ToString();
            string chinhanh = cbb_chinhanh.SelectedItem.ToString();

            KhachHangBUS.Instance.AddNew(name, addr, phone, sex, dob, nhucau, maln, tieuchi, chinhanh);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //thêm đã fix
            string name = tb_name.Text;
            string addr = tb_address.Text;
            string phone = tb_phone.Text;
            string tieuchi = tb_tieuchi.Text;
            DateTime dob = dayofbitrh.Value;
            string sex = cbb_chinhanh.SelectedItem.ToString();
            int nhucau = int.Parse(cbb_nhucau.SelectedItem.ToString());
            string maln = cbb_loainha.SelectedItem.ToString();
            string chinhanh = cbb_chinhanh.SelectedItem.ToString();

            KhachHangBUS.Instance.AddNewFixed(name, addr, phone, sex, dob, nhucau, maln, tieuchi, chinhanh);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable customers = KhachHangBUS.Instance.GetAll();
            Tran1DataGridView.DataSource = customers;
        }
    }
}
