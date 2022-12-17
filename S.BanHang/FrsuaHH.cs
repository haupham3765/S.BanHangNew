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

    public partial class FrsuaHH : Form
    {

        // static DataTable b = new DataTable();
        public FrsuaHH()
        {
            InitializeComponent();
        }
        public delegate void capnhatdulieu();

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn thoát không ??", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
                this.Close();
        }

        private void Frsua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetDMTK.DANHMUCTAIKHOAN' table. You can move, or remove it, as needed.
            this.dANHMUCTAIKHOANTableAdapter.Fill(this._S_BaoGiaDataSetDMTK.DANHMUCTAIKHOAN);
            //try {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetDVT.DVT' table. You can move, or remove it, as needed.
            this.dVTTableAdapter.Fill(this._S_BaoGiaDataSetDVT.DVT);
                // TODO: This line of code loads data into the '_S_BaoGiaDataSetKHO.KHO' table. You can move, or remove it, as needed.
                this.kHOTableAdapter.Fill(this._S_BaoGiaDataSetKHO.KHO);
                // TODO: This line of code loads data into the '_S_BaoGiaDataSetSuaMH.HANGHOA' table. You can move, or remove it, as needed.
                this.hANGHOATableAdapterSua.Fill(this._S_BaoGiaDataSetSuaMH.HANGHOA, this.ma.ToString().Trim());
                // TODO: This line of code loads data into the '_S_BaoGiaDataSetHH.HANGHOA' table. You can move, or remove it, as needed.
                //  this.hANGHOATableAdapter.Fill(this._S_BaoGiaDataSetHH.HANGHOA);
                txtmahh.Text = ma;
          
            //    txtgia.Text = string.Format("{0:N0}", float.Parse(txtgia.Text));
            // txtgiaban.Text = string.Format("{0:N0}", float.Parse(txtgiaban.Text));
        }//catch (Exception) { }
        public string ma { get; set; }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmahh.Text =="" || txttenmh.Text =="" || txtgia.Text ==""|| txtgiaban.Text == "" || txtsoluongtonkho.Text=="")
            {
                MessageBox.Show("Hãy nhập thông tin bắt buộc");  
            }
            else
            {
                try
                {
                    this.hANGHOATableAdapterSua.Update(txtmahh.Text.ToString().Trim(), txttenmh.Text.ToString().Trim(), cbdvt.Text.ToString().Trim(), double.Parse(txtgia.Text.ToString().Trim()), txtxuatxu.Text.ToString().Trim(), txtdiengiai.Text.ToString().Trim(), "", cbkho.Text.ToString().Trim(), txthangmuc.Text.ToString().Trim(), double.Parse(txtgiaban.Text.ToString().Trim()), Int32.Parse(txtsoluongtonkho.Text.ToString().Trim()), cbtkvt.Text.ToString().Trim());
                    MessageBox.Show("Lưu thành công!!!");
                    this.hANGHOATableAdapterSua.Fill(this._S_BaoGiaDataSetSuaMH.HANGHOA, this.ma.ToString().Trim());
                    this.Close();
                }
                catch (Exception) { }
            }
        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtgia.Text = string.Format("{0:N0}", float.Parse(txtgia.Text));
                ((TextBox)sender).Select(((TextBox)sender).Text.Length, 1);
            }
            catch (Exception ex){}
        }

        private void txtgiaban_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtgiaban.Text = string.Format("{0:N0}", float.Parse(txtgiaban.Text));
                ((TextBox)sender).Select(((TextBox)sender).Text.Length, 1);
            }
            catch (Exception) { }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
