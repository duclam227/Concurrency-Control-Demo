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
    }
}
