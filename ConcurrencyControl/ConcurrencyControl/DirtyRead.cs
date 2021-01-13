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
    }
}
