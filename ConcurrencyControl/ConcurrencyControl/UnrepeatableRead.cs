﻿using System;
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
    public partial class UnrepeatableRead : Form
    {
        public UnrepeatableRead()
        {
            InitializeComponent();
        }

        private void CountSellingHousesButton_Click(object sender, EventArgs e)
        {
            Tuple<DataTable, int> data;
            DateTime date = dateTimePicker.Value;
            data = ConcurrencyControl_BUS.NhaBUS.Instance.GetSellingHouses(date);

            Tran1DataGridView.DataSource = data.Item1;
            AmountLabel.Text = data.Item2.ToString();
        }

        private void ChangeToRentButton_Click(object sender, EventArgs e)
        {
            string id = Tran2InputHouseID.Text;
            NhaBUS.Instance.ChangeToRent(id);
        }

        private void CountSellingHousesFixedButton_Click(object sender, EventArgs e)
        {
            Tuple<DataTable, int> data;
            DateTime date = dateTimePicker.Value;
            data = ConcurrencyControl_BUS.NhaBUS.Instance.GetSellingHousesFixed(date);

            Tran1DataGridView.DataSource = data.Item1;
            AmountLabel.Text = data.Item2.ToString();
        }

        private void ShowViewingButton_Click(object sender, EventArgs e)
        {
            string id = Tran1InputIDTextBox.Text;
            Tuple<DataTable, int> data;
            data = LuotXemBUS.Instance.GetViewingOfCustomer(id);

            Tran1ViewingDataGridView.DataSource = data.Item1;
            ViewingAmount.Text = data.Item2.ToString();
        }

        private void ShowViewingFixedButton_Click(object sender, EventArgs e)
        {
            string id = Tran1InputIDTextBox.Text;
            Tuple<DataTable, int> data;
            data = LuotXemBUS.Instance.GetViewingOfCustomerFixed(id);

            Tran1ViewingDataGridView.DataSource = data.Item1;
            ViewingAmount.Text = data.Item2.ToString();
        }

        private void DeleteViewingButton_Click(object sender, EventArgs e)
        {
            string id = Tran2IDInputTextBox.Text;
            DateTime date = dateTimePicker1.Value;

            LuotXemBUS.Instance.DeleteViewing(id, date);
        }
    }
}
