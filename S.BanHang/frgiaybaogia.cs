using System;
using System.IO;
using Syncfusion.XlsIO;
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
    public partial class frgiaybaogia : Form
    {
        public frgiaybaogia()
        {
            InitializeComponent();
         //   Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            //Application.EnableVisualStyles();
          //  Application.SetCompatibleTextRenderingDefault(false);
        }

        private void frgiaybaogia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetBG.BAOGIAKH' table. You can move, or remove it, as needed.
            this.bAOGIAKHTableAdapter.Fill(this._S_BaoGiaDataSetBG.BAOGIAKH);
            //   this.ma.ToString().Trim()
            this.baogiAtempTableAdapter1.Fill(this._S_BaoGiaDataSetBGtemp.BAOGIAtemp,txtmabg.Text.Trim());
            //  txtmanv.Text = manv;

        }
        public string manv { get; set; }

        private void btnthem1_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    frthemgiaybaogia frthemgiaybaogia = new frthemgiaybaogia();
                    frthemgiaybaogia.ShowDialog();
                    //---------------------------------------//
                    this.bAOGIAKHTableAdapter.Fill(this._S_BaoGiaDataSetBG.BAOGIAKH);
                    this.Refresh();
                }
                catch (Exception ex) { }
            }
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            frXEMgiaybg frXEMgiaybg = new frXEMgiaybg();
            //frXEMgiaybg.ma = txtmabg.Text.ToString().Trim();
            frXEMgiaybg.ma = dataGridView1.CurrentRow.Cells["sobaogia"].Value.ToString().Trim();
            frXEMgiaybg.ShowDialog();


        }

        private void btnxoa1_Click(object sender, EventArgs e)
        {

            DialogResult ch = MessageBox.Show("Bạn có muốn xóa báo giá " + txtmabg.Text.Trim() + " Không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: Xoá  
            if (ch == DialogResult.Yes)
            {
                bAOGIAKHTableAdapter.Delete(txtmabg.Text.Trim());
                baogiAtempTableAdapter1.Delete(txtmabg.Text.Trim());
                this.bAOGIAKHTableAdapter.Fill(this._S_BaoGiaDataSetBG.BAOGIAKH);
                this.baogiAtempTableAdapter1.Fill(this._S_BaoGiaDataSetBGtemp.BAOGIAtemp, txtmabg.Text.Trim());
                MessageBox.Show("Đã xóa xong !!!");
                this.Refresh();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.baogiAtempTableAdapter1.Fill(this._S_BaoGiaDataSetBGtemp.BAOGIAtemp, txtmabg.Text.ToString().Trim());
        }

        private void btnin_Click(object sender, EventArgs e)
        {
          
            
            using (ExcelEngine excelEngine = new ExcelEngine())
            {


                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Xlsx;

                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet worksheet = workbook.Worksheets[0];
              


                //Load lai sheet
                //IWorkbook workbook = application.Workbooks.Open("Sample.xlsx");



                /////excel
                worksheet.Range["A1"].Text = "ok nha ae";
                worksheet.Range["B4"].Text = "ok nha ae";
                worksheet.Range["E1"].Text = "ok nha ae";
                worksheet.Range["D1"].Text = "ok nha ae";
                worksheet.Range["B1"].Text = "ok nha ae";



                ///Luuw

                workbook.SaveAs("C:\\Users\\GOCONGS\\Desktop\\Output.xlsx");
              


                MessageBox.Show("Đã xuất xong!!!");
             //   workbook = application.Workbooks.Open("C:\\Users\\GOCONGS\\Desktop\\Output.xlsx");
            }
        }

        private void btnsua1_Click(object sender, EventArgs e)
        {
            frsuagiayBG frsuagiayBG = new frsuagiayBG();
            //frXEMgiaybg.ma = txtmabg.Text.ToString().Trim();
            frsuagiayBG.ma = dataGridView1.CurrentRow.Cells["sobaogia"].Value.ToString().Trim();
            frsuagiayBG.ShowDialog();
        }
    }
}
