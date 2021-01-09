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

            DataTable hopDongData = ConcurrencyControl_BUS.HopDongBUS.Instance.GetAllContracts();
            HopDongDataGridView.DataSource = hopDongData;
        }

        
    }
}
