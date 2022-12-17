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
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void TEST_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetHH.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this._S_BaoGiaDataSetHH.HANGHOA);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            


        }
    }
}
