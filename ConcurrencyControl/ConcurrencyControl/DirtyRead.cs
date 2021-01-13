using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyControl
{
    public partial class DirtyRead : Form
    {

        public DirtyRead()
        {
            InitializeComponent();
        }

        private void ShowContract_Click(object sender, EventArgs e)
        {
            //gọi proc chưa fix
            DataTable result = ConcurrencyControl_BUS.HopDongBUS.Instance.GetContractByID(inputIDTextBox2.Text);
            Tran2DataGridView.DataSource = result;
        }

        private void ShowContractFixed_Click(object sender, EventArgs e)
        {
            //gọi proc đã fix
            DataTable result = ConcurrencyControl_BUS.HopDongBUS.Instance.GetContractByIDFixed(inputIDTextBox2.Text);
            Tran2DataGridView.DataSource = result;
        }

        private void DateUpdateButton_Click(object sender, EventArgs e)
        {
            string id = inputIDTextBox1.Text;
            DateTime newDate = dateTimePicker.Value;

            //gọi proc update
            ConcurrencyControl_BUS.HopDongBUS.Instance.UpdateEndDate(id, newDate);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DataTable hopDongData = ConcurrencyControl_BUS.HopDongBUS.Instance.GetAllContracts();
            Tran1DataGridView.DataSource = hopDongData;
        }

        private void Update_DR_TH2_GT1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            DateTime newDate = dateTimePicker1.Value;

            //gọi proc update
            ConcurrencyControl_BUS.NhaBUS.Instance.UpdateEndDate(id, newDate);

            MessageBox.Show("Completed");
            DataTable NhaTable = ConcurrencyControl_BUS.NhaBUS.Instance.GetAHouseData_Fix(id);    
            DR_TH2_GT1.DataSource = NhaTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable NHATABLE = ConcurrencyControl_BUS.NhaBUS.Instance.ShowListHouse();
            DR_TH2_GT1.DataSource = NHATABLE;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;
            DataTable NhaTable = ConcurrencyControl_BUS.NhaBUS.Instance.GetAHouseData(id);
            DR_TH2_GT2.DataSource = NhaTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;
            DataTable NhaTable = ConcurrencyControl_BUS.NhaBUS.Instance.GetAHouseData_Fix(id);
            DR_TH2_GT2.DataSource = NhaTable;
        }
    }
}
