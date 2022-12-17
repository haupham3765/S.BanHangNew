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
    public partial class frdmtaikhoan : Form
    {
        public frdmtaikhoan()
        {
            InitializeComponent();
            this.Refresh();
        }

        private void frdmtaikhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetSDDK.SODUDK' table. You can move, or remove it, as needed.
            this.sODUDKTableAdapter.Fill(this._S_BaoGiaDataSetSDDK.SODUDK);
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetDMTK.DANHMUCTAIKHOAN' table. You can move, or remove it, as needed.
            this.dANHMUCTAIKHOANTableAdapter.Fill(this._S_BaoGiaDataSetDMTK.DANHMUCTAIKHOAN);
            this.Refresh();
        }

        private void btnthem1_Click(object sender, EventArgs e)
        {
            frthemDMTK frthemDMTK = new frthemDMTK();
            frthemDMTK.Show();

            this.Refresh();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.dANHMUCTAIKHOANTableAdapter.Fill(this._S_BaoGiaDataSetDMTK.DANHMUCTAIKHOAN);
            //frdmtaikhoan frdmtaikhoan = new frdmtaikhoan();
            //frdmtaikhoan.TopLevel = false;
            //frdmtaikhoan.Dock = DockStyle.Fill;
            //frdmtaikhoan.Show();
        }

        private void btnxoa1_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn xóa tài khoản: " + txtsotk.Text.Trim() + " Không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: Xoá  
            if (ch == DialogResult.Yes)
            {
                dANHMUCTAIKHOANTableAdapter.Delete(txtsotk.Text.Trim());
                MessageBox.Show("Đã xóa xong !!!");
                this.dANHMUCTAIKHOANTableAdapter.Fill(this._S_BaoGiaDataSetDMTK.DANHMUCTAIKHOAN);
                this.Refresh();
            }
        }
    }
}
