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
    public partial class frsuagiayBG : Form
    {
        public frsuagiayBG()
        {
            InitializeComponent();
        }
        
        private void frsuagiayBG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetSuactBG.BAOGIAtemp' table. You can move, or remove it, as needed.
            this.bAOGIAtempTableAdapter1.Fill(this._S_BaoGiaDataSetSuactBG.BAOGIAtemp,ma.ToString().Trim());
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetSuaBG.BAOGIAKH' table. You can move, or remove it, as needed.
            this.bAOGIAKHTableAdapter.Fill(this._S_BaoGiaDataSetSuaBG.BAOGIAKH);
          
            txtsobg.Text = ma;
        }
        public string ma{ get; set; }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn thoát không ??", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
                this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try {
                bAOGIAKHTableAdapter.Update(int.Parse(txthieuluc.Text.ToString().Trim()), float.Parse(txttongcong.Text.ToString().Trim()), txtmakh.Text.ToString().Trim(), txtmanhanvien.Text.ToString().Trim(), txtphantramchietkhau.Text.ToString().Trim(), cbtrangthai.Text.ToString().Trim(), "", txttenbg.Text.ToString().Trim(), txtphantramthue.Text.ToString().Trim(), int.Parse(txttongsoluong.Text.ToString().Trim()), double.Parse(txttienthue.Text.ToString().Trim()), double.Parse(txttienchietkhau.Text.ToString().Trim()), double.Parse(txttongtienhang.Text.ToString().Trim()), double.Parse(txttienvanchuyen.Text.ToString().Trim()), txtsobg.Text.ToString().Trim());

                MessageBox.Show("Lưu thành công !!!");
                // bAOGIAKHTableAdapter.Update(int.Parse(txthieuluc.Text.ToString().Trim()), double.Parse(txttongtienhang.ToString().Trim()), txtmakh.Text.ToString().Trim(), txtmanhanvien.Text.ToString().Trim(), txtphantramchietkhau.Text.ToString().Trim(), cbtrangthai.Text.Trim(), "", txttenbg.Text.ToString().Trim(), txtphantramthue.Text.ToString().Trim(), int.Parse(txttongsoluong.Text.Trim()), double.Parse(txttienthue.Text.ToString().Trim()), double.Parse(txttienchietkhau.Text.ToString().Trim()), double.Parse(txttongtienhang.Text.ToString().Trim()), double.Parse(txttienvanchuyen.Text.ToString().Trim()), txtsobg.Text.Trim());
            }
            catch (Exception) { }
            }
    }
}
