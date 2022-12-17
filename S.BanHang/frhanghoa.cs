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
   
    public partial class frhanghoa : Form
    {
    

        public frhanghoa()
        {
          
            InitializeComponent();
        }
     
        public void frhanghoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetHH.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this._S_BaoGiaDataSetHH.HANGHOA);
            this.Refresh();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
        
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnthem_Click(object sender, EventArgs e) { }
private void btnthem1_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    frthemHH frthem = new frthemHH();
                    frthem.ShowDialog();
                    //---------------------------------------//
                    this.hANGHOATableAdapter.Fill(this._S_BaoGiaDataSetHH.HANGHOA);
                    this.Refresh();
                }
                catch (Exception ex) { }
            }
        }

        private void btnsua1_Click(object sender, EventArgs e)
        {
            // try
            {
                FrsuaHH frsua = new FrsuaHH();
                frsua.ma = dataGridViewMH.CurrentRow.Cells["mahangDataGridViewTextBoxColumn"].Value.ToString().Trim();
                frsua.ShowDialog();
                this.hANGHOATableAdapter.Fill(this._S_BaoGiaDataSetHH.HANGHOA);
                this.Refresh();
            }// catch (Exception ex) { }
        }

        private void btnxoa1_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn xóa mặt hàng mã: " + txtmahh.Text.Trim() + " Không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: Xoá  
            if (ch == DialogResult.Yes)
            {
                hANGHOATableAdapter.Delete(txtmahh.Text.Trim());
                MessageBox.Show("Đã xóa xong !!!");
                this.hANGHOATableAdapter.Fill(this._S_BaoGiaDataSetHH.HANGHOA);
                this.Refresh();

            }
        }
    }
}
