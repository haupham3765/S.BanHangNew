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
    public partial class frlogin : Form
    {
        public frlogin()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(txtuser.Text =="" || txtpass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!!!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
               if(txtuser.Text == "admin" || txtpass.Text == "admin" && txtuser.Text == "hau" || txtpass.Text == "12345" && txtuser.Text == "nga" || txtpass.Text == "12345")
                {
                    frmain frmain = new frmain(txtuser.Text);
                    frmain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng thử lại !!!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
                
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btneye_MouseDown(object sender, MouseEventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
        }

        private void btneye_MouseUp(object sender, MouseEventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ với quản lý để cấp lại mật khẩu......");
        }
    }
}
