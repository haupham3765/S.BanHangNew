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
    public partial class frhopdong : Form
    {
        public frhopdong()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frhopdong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetBGHopDong.BAOGIAKH' table. You can move, or remove it, as needed.
            this.bAOGIAKHTableAdapter1.Fill(this._S_BaoGiaDataSetBGHopDong.BAOGIAKH,txttrangthai.Text.Trim());
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetBG.BAOGIAKH' table. You can move, or remove it, as needed.
            this.bAOGIAKHTableAdapter.Fill(this._S_BaoGiaDataSetBG.BAOGIAKH);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
