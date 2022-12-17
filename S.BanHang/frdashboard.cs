using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.BanHang
{
    public partial class frdashboard : Form
    {
        public frdashboard()
        {
            InitializeComponent();
        }

        private void frdashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetChart.DOANHTHU' table. You can move, or remove it, as needed.
            this.dOANHTHUTableAdapter.Fill(this._S_BaoGiaDataSetChart.DOANHTHU);

        }
    }
}
