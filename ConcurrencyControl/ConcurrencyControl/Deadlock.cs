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
    public partial class Deadlock : Form
    {
        public Deadlock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable NHATABLE = ConcurrencyControl_BUS.NhaBUS.Instance.ShowListHouse();
            dataGridView1.DataSource = NHATABLE;
        }

        private void Change_CDL_1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            DateTime newDate = dateTimePicker1.Value;

            //gọi proc update
            ConcurrencyControl_BUS.NhaBUS.Instance.Update_DL(id, newDate);

            MessageBox.Show("Completed");
            DataTable NhaTable = ConcurrencyControl_BUS.NhaBUS.Instance.GetAHouseData_Fix(id);
            CDL_1.DataSource = NhaTable;
        }

        private void Change_DL_fix_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            DateTime newDate = dateTimePicker1.Value;

            //gọi proc update
            ConcurrencyControl_BUS.NhaBUS.Instance.Update_DL_Fix(id, newDate);

            MessageBox.Show("Completed");
            DataTable NhaTable = ConcurrencyControl_BUS.NhaBUS.Instance.GetAHouseData_Fix(id);
            CDL_1.DataSource = NhaTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;
            string _SDT;

            _SDT = ConcurrencyControl_BUS.NhaBUS.Instance.SellHouse(id);    
            MessageBox.Show($"So dien thoai chu nha: {_SDT}");
            DataTable NhaTable = ConcurrencyControl_BUS.NhaBUS.Instance.GetAHouseData_Fix(id);
            dataGridView1.DataSource = NhaTable;
        }
    }
}
