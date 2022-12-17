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
    
    public partial class frmain : Form
    {
        public string username;
        public frmain( string user)
        {
            InitializeComponent();
            this.username = user;
        }

       
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void frmain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetChart.DOANHTHU' table. You can move, or remove it, as needed.
            this.dOANHTHUTableAdapter.Fill(this._S_BaoGiaDataSetChart.DOANHTHU);
            lbuser.Text = username;
            if (username == "admin")
            {
                MessageBox.Show("XIN CHÀO ADMIN!!!");
            }
            else
 
            tàiKhoảnToolStripMenuItem.Visible = false;
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frlogin frlogin = new frlogin();
            frlogin.Show();
            this.Hide();
        }
        //Gọi form hàng hóa
        private void danhMụcVậtTưhàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel.Controls.Clear();
          frhanghoa frhanghoa = new frhanghoa();
            frhanghoa.TopLevel = false;
            panel.Controls.Add(frhanghoa);
            frhanghoa.Dock = DockStyle.Fill;
            frhanghoa.Show();
     
        }
        //gọi form báo giá
        private void báoGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frgiaybaogia frgiaybaogia = new frgiaybaogia();
            frgiaybaogia.TopLevel = false;
            panel.Controls.Add(frgiaybaogia);
            frgiaybaogia.Dock = DockStyle.Fill;
            frgiaybaogia.Show();
       
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Bạn có muốn thoát khum?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes )
            {
                Application.Exit();

            }
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frdashboard frdashboard = new frdashboard();
            frdashboard.TopLevel = false;
            panel.Controls.Add(frdashboard);
            frdashboard.Dock = DockStyle.Fill;
            frdashboard.Show();
        }

        private void danhMụcTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frdmtaikhoan frdmtaikhoan = new frdmtaikhoan();
            frdmtaikhoan.TopLevel = false;
            panel.Controls.Add(frdmtaikhoan);
            frdmtaikhoan.Dock = DockStyle.Fill;
            frdmtaikhoan.Show();
        }

        private void khaiBáoNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
           fruser fruser = new fruser();
            fruser.TopLevel = false;
            panel.Controls.Add(fruser);
            fruser.Dock = DockStyle.Fill;
            fruser.Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frkhachhang frkhachhang = new frkhachhang();
            frkhachhang.TopLevel = false;
            panel.Controls.Add(frkhachhang);
            frkhachhang.Dock = DockStyle.Fill;
            frkhachhang.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frdoimatkhau frdoimatkhau = new frdoimatkhau();
            frdoimatkhau.TopLevel = false;
            panel.Controls.Add(frdoimatkhau);
            frdoimatkhau.Dock = DockStyle.Fill;
            frdoimatkhau.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frhopdong frhopdong = new frhopdong();
            frhopdong.TopLevel = false;
            panel.Controls.Add(frhopdong);
            frhopdong.Dock = DockStyle.Fill;
            frhopdong.Show();
        }
    }
}
