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
    public partial class frXEMgiaybg : Form
    {
     
        public frXEMgiaybg()
        {
            InitializeComponent();
          
        }



        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frXEMgiaybg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetXEMbg.BAOGIAKH' table. You can move, or remove it, as needed.
            this.bAOGIAKHTableAdapter.Fill(this._S_BaoGiaDataSetXEMbg.BAOGIAKH, this.ma.ToString().Trim());
         //   this.bAOGIAtempTableAdapter.Fill(this._S_BaoGiaDataSetBGtemp.BAOGIAtemp, txtsobg.Text.ToString().Trim());
            this.bAOGIAtempTableAdapter.Fill(this._S_BaoGiaDataSetBGtemp.BAOGIAtemp,txtsobg.Text.ToString().Trim());
            txtsobg.Text = ma;
           
        }

        public string ma { get; set; }

        private void fullToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bAOGIAtempTableAdapter.Full(this._S_BaoGiaDataSetBGtemp.BAOGIAtemp);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
