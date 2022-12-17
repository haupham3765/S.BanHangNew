using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace S.BanHang
{
    
    public partial class frthemgiaybaogia : Form
    {
        static DataTable b = new DataTable();
        static DataTable tb = new DataTable();
        
        public frthemgiaybaogia()
        {

            InitializeComponent();
        }

        private void frthemgiaybaogia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetCK.CHIETKHAU' table. You can move, or remove it, as needed.
            this.cHIETKHAUTableAdapter.Fill(this._S_BaoGiaDataSetCK.CHIETKHAU);
            
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetNV.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this._S_BaoGiaDataSetNV.NHANVIEN);
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetBGtemp.BAOGIAtemp' table. You can move, or remove it, as needed.
            this.bAOGIAtempTableAdapter.Fill(this._S_BaoGiaDataSetBGtemp.BAOGIAtemp, txtsobg.Text.ToString().Trim());
            //  this.bAOGIAtempTableAdapter.Fill(this._S_BaoGiaDataSetBGtemp.BAOGIAtemp, txtsobg.Text.ToString().Trim());
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetKH.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this._S_BaoGiaDataSetKH.KHACHHANG);

            // TODO: This line of code loads data into the '_S_BaoGiaDataSetCTBG.CHITIETBAOGIA' table. You can move, or remove it, as needed.
            this.cHITIETBAOGIATableAdapter.Fill(this._S_BaoGiaDataSetCTBG.CHITIETBAOGIA);
            // TODO: This line of code loads data into the '_S_BaoGiaDataSetHH.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this._S_BaoGiaDataSetHH.HANGHOA);
            cbtrangthai.Text = "Lập báo giá";
            txtphantramthue.Text = "10";
            txtphantramchietkhau.Text = "0";
            txtmanhanvien.Text = "admin";
            txtmakh.Text = "hau";
            
            lbngaylap.Text = System.DateTime.Now.ToShortDateString();
            txtsobg.Focus();
            
            /////
            b.Rows.Clear();
            b.Columns.Clear();
            b.Columns.Add("tenhang", typeof(string));
            b.Columns.Add("soluong", typeof(Int32));
            b.Columns.Add("giaban", typeof(float));
            b.Columns.Add("mahang", typeof(string));
            b.Columns.Add("sobg", typeof(string));
            b.Columns.Add("thanhtien", typeof(float), "soluong * giaban");

            //dataGridViewchinh.DataSource= a;
            //a.AcceptChanges();
        }
        public string ma { get; set; }
        static int pos = 0;
        static int vt = 0;
        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn thoát không ??", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
                this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                baogiakhTableAdapter1.Insert(txtsobg.Text.ToString().Trim(), DateTime.Parse((lbngaylap.Text.Trim()).ToString()), int.Parse(txthieuluc.Text.ToString().Trim()), float.Parse(txttongcong.Text.ToString().Trim()), txtmakh.Text.ToString().Trim(), txtmanhanvien.Text.ToString().Trim(), txtphantramchietkhau.Text.ToString().Trim(), cbtrangthai.Text.ToString().Trim(), txttenbg.Text.ToString().Trim(), txtphantramthue.Text.ToString().Trim(), int.Parse(txtsoluong.Text.ToString().Trim()), double.Parse(txttienthue.Text.ToString().Trim()), double.Parse(txttienchietkhau.Text.ToString().Trim()), double.Parse(txttongtienhang.Text.ToString().Trim()), double.Parse(txttienvanchuyen.Text.ToString().Trim()));

                for (int i = 0; i < dataGridViewchinh.RowCount - 1; i++)
                {
                    //   bAOGIAtempTableAdapter.Insert(dataGridViewchinh.Rows[i].Cells[5].Value.ToString().Trim(), dataGridViewchinh.Rows[i].Cells[0].Value.ToString().Trim(),Int32.Parse(dataGridViewchinh.Rows[i].Cells[1].Value.ToString()), double.Parse(dataGridViewchinh.Rows[i].Cells[3].Value.ToString().Trim()), double.Parse(dataGridViewchinh.Rows[i].Cells[2].Value.ToString().Trim()));
                    bAOGIAtempTableAdapter.Insert(dataGridViewchinh.Rows[i].Cells[5].Value.ToString().Trim(), dataGridViewchinh.Rows[i].Cells[0].Value.ToString().Trim(), Int32.Parse(dataGridViewchinh.Rows[i].Cells[1].Value.ToString().Trim()), 333, 999, txtsobg.Text.ToString().Trim());

                }

                MessageBox.Show("Them thanh cong ");
                this.Close();

            } catch (System.Exception ex)

            {
                MessageBox.Show("Có lỗi thêm mới" + ex.Message);
            }


            // this.Close();

        }



        private void txtphantramthue_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
            NhapCK();
            Nhapthue();
        }

        private void txtphantramchietkhau_TextChanged(object sender, EventArgs e)
        {
            if (txtphantramchietkhau.Text == "")
            {
                txtphantramchietkhau.Text = "0";
            }
            else
            {
                TinhTien();
                NhapCK();
                Nhapthue();
            }
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMH.Rows.Count > 1) //Có MH trong DS mặt hàng
                {

                    DataGridViewRow h = dataGridViewMH.Rows[vt];


                    foreach (DataRow r in b.Rows)

                    {
                        if ((string)r["mahang"] == h.Cells[3].Value.ToString().Trim())

                        {
                            r["soluong"] = (int)r["soluong"] + int.Parse(txtsoluong.Text.ToString().Trim());
                            goto kt;
                        }
                    }
                    // MessageBox.Show(dataGridViewchinh.Rows[1].Cells["sobg"].ToString().Trim());

                    //      b.Rows.Add(h.Cells[0].Value.ToString().Trim(), int.Parse(txtsoluong.Text.Trim()), float.Parse(h.Cells[1].Value.ToString().Trim()), h.Cells[3].Value.ToString().Trim(),txtsobg.Text.ToString().Trim());
                    b.Rows.Add(h.Cells[0].Value.ToString().Trim(), int.Parse(txtsoluong.Text.Trim()), float.Parse(h.Cells[1].Value.ToString().Trim()), h.Cells[3].Value.ToString().Trim(), txtsobg.Text.ToString().Trim());

                kt:;

                    {

                        txttongtienhang.Text = (b.Compute("Sum(thanhtien)", "").ToString());
                        txttongsoluong.Text = (b.Compute("Sum(soluong)", "").ToString());

                        txttongtienhang.Text = string.Format("{0:N0}", float.Parse(txttongtienhang.Text));
                        dataGridViewchinh.DataSource = b;

                    }

                }

            } catch (System.Exception ex)

            {
                MessageBox.Show("Có lỗi thêm mới" + ex.Message);
            }
        }


        //NhapCK
        public void NhapCK()
        {
            if (txttongtienhang.Text != "0")
            {
                try
                {
                    double tongtien = Convert.ToDouble(txttongtienhang.Text);
                    int phantramck = Convert.ToInt16(txtphantramchietkhau.Text);
                    double ck = tongtien * phantramck / 100;
                    txttienchietkhau.Text = string.Format("{0:N0}", float.Parse(ck.ToString()));
                }
                catch (Exception) { }
            }
        }

        //NhapThue
        public void Nhapthue()
        {
            try
            {
                if (txttongtienhang.Text != "0")
                {
                    double tongtien = Convert.ToDouble(txttongtienhang.Text);
                    double ck = Convert.ToDouble(txttienchietkhau.Text);
                    double phantramthue = Convert.ToDouble(txtphantramthue.Text);
                    double tinhthue = ((tongtien - ck) * phantramthue / 100);
                    txttienthue.Text = string.Format("{0:N0}", float.Parse(tinhthue.ToString()));
                }
            }

            catch (Exception) { };
        }

        private void dataGridViewMH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            vt = e.RowIndex;// lấy vị trí dòng chọn
            txtsoluong.Text = "1";
        }


        private void dataGridViewMH_SelectionChanged(object sender, EventArgs e)
        {

        }

        //tinhtien
        public void TinhTien()
        {
            try
            {

                double tongtienhang = Convert.ToDouble(txttongtienhang.Text);
                double tienthue = Convert.ToDouble(txttienthue.Text);
                double tienchietkhau = Convert.ToDouble(txttienchietkhau.Text);
                double tongcong = tongtienhang + tienthue - tienchietkhau;
                txttongcong.Text = string.Format("{0:N0}", float.Parse(tongcong.ToString()));
            }
            catch(Exception) { }
        }

        private void txttongtienhang_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
            NhapCK();
            Nhapthue();
        }

        private void txtphantramthue_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTien();
            NhapCK();
            Nhapthue();
        }

        private void txttienthue_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
            NhapCK();
            Nhapthue();
        }

        private void txttienvanchuyen_TextChanged(object sender, EventArgs e)
        {
            if (txttienvanchuyen.Text == "")
            {
                txttienvanchuyen.Text = "";
            }
            TinhTien();
            NhapCK();
            Nhapthue();
        }
        //Khi trống
        public void Griptrong()
        {
            if (dataGridViewchinh.Rows.Count == 0)
            {
                txttongtienhang.Text = "";
                txttongcong.Text = "";
            }
        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            // try
            {
                MessageBox.Show("Bạn có muốn xóa mặt hàng", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                {
                    Griptrong();
                }
                b.Rows.RemoveAt(pos);
                txttongcong.Text = (b.Compute("Sum(thanhtien)", "").ToString());
                dataGridViewchinh.DataSource = b;
                TinhTien();
                NhapCK();
                Nhapthue();
                this.Refresh();
            }
            //  catch (Exception) { }



        }

        private void txtsobg_TextChanged(object sender, EventArgs e)
        {
            if (txtsobg.Text != "")
            {
                btnchon.Enabled = true;
            }
        }

        private void dataGridViewchinh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txttongtienhang.Text = (b.Compute("Sum(thanhtien)", "").ToString());
                txttongsoluong.Text = (b.Compute("Sum(soluong)", "").ToString());

                txttongtienhang.Text = string.Format("{0:N0}", float.Parse(txttongtienhang.Text));
                dataGridViewchinh.DataSource = b;
            }
            catch (Exception) { }
        }

     

        private void dataGridViewMH_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnchon_Click(sender, e);
        }
    }
    
}
