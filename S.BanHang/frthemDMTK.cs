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
    public partial class frthemDMTK : Form
    {
        public frthemDMTK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                this.dANHMUCTAIKHOANTableAdapter.Insert(txtsotk.Text.Trim(), txttentk.Text.Trim(), 0, 0);
                MessageBox.Show("Thêm thành công!!!");

                //===========================//
                this.dANHMUCTAIKHOANTableAdapter.Fill(this._S_BaoGiaDataSetDMTK.DANHMUCTAIKHOAN);
                this.Close();
            }
            catch(System.Exception ex)
            { MessageBox.Show("Tài khoản đã tồn tại trong danh mục"); }
        }

        private void frthemDMTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetDMTK.DANHMUCTAIKHOAN' table. You can move, or remove it, as needed.
            this.dANHMUCTAIKHOANTableAdapter.Fill(this._S_BaoGiaDataSetDMTK.DANHMUCTAIKHOAN);

        }

        private void frthemDMTK_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dANHMUCTAIKHOANTableAdapter.Fill(this._S_BaoGiaDataSetDMTK.DANHMUCTAIKHOAN);
        }
    }
}
