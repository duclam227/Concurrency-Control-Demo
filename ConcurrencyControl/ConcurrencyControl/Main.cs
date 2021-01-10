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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void DRButton_Click(object sender, EventArgs e)
        {
            DirtyRead dRForm = new DirtyRead();
            dRForm.ShowDialog(this);
        }

        private void LUButton_Click(object sender, EventArgs e)
        {
            LostUpdate lUForm = new LostUpdate();
            lUForm.ShowDialog(this);
        }

        private void PButton_Click(object sender, EventArgs e)
        {
            Phantom pForm = new Phantom();
            pForm.ShowDialog(this);
        }

        private void URButton_Click(object sender, EventArgs e)
        {
            UnrepeatableRead uRForm = new UnrepeatableRead();
            uRForm.ShowDialog(this);
        }

        private void DButton_Click(object sender, EventArgs e)
        {
            Deadlock dForm = new Deadlock();
            dForm.ShowDialog(this);
        }
    }
}
