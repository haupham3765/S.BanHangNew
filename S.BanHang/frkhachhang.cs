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
    public partial class frkhachhang : Form
    {
        public frkhachhang()
        {
            InitializeComponent();
        }

        private void frkhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetKH.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this._S_BaoGiaDataSetKH.KHACHHANG);

        }
    }
}
