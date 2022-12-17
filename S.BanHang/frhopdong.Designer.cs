namespace S.BanHang
{
    partial class frhopdong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnthem1 = new System.Windows.Forms.ToolStripLabel();
            this.btnsua1 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoa1 = new System.Windows.Forms.ToolStripLabel();
            this.btnin = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bAOGIAKHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._S_BaoGiaDataSetBGHopDong = new S.BanHang._S_BaoGiaDataSetBGHopDong();
            this.bAOGIAKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._S_BaoGiaDataSetBG = new S.BanHang._S_BaoGiaDataSetBG();
            this.label3 = new System.Windows.Forms.Label();
            this.bAOGIAKHTableAdapter = new S.BanHang._S_BaoGiaDataSetBGTableAdapters.BAOGIAKHTableAdapter();
            this.bAOGIAKHTableAdapter1 = new S.BanHang._S_BaoGiaDataSetBGHopDongTableAdapters.BAOGIAKHTableAdapter();
            this.sobaogiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbaogiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybaogiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hieulucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongsoluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOGIAKHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetBGHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOGIAKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetBG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem1
            // 
            this.btnthem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem1.Image = global::S.BanHang.Properties.Resources.add_file;
            this.btnthem1.Name = "btnthem1";
            this.btnthem1.Size = new System.Drawing.Size(92, 22);
            this.btnthem1.Text = "Thêm mới";
            // 
            // btnsua1
            // 
            this.btnsua1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua1.Image = global::S.BanHang.Properties.Resources.writing;
            this.btnsua1.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnsua1.Name = "btnsua1";
            this.btnsua1.Size = new System.Drawing.Size(50, 22);
            this.btnsua1.Text = "Sửa";
            // 
            // btnxoa1
            // 
            this.btnxoa1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa1.Image = global::S.BanHang.Properties.Resources.delete;
            this.btnxoa1.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnxoa1.Name = "btnxoa1";
            this.btnxoa1.Size = new System.Drawing.Size(51, 22);
            this.btnxoa1.Text = "Xóa";
            // 
            // btnin
            // 
            this.btnin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.Image = global::S.BanHang.Properties.Resources.printer;
            this.btnin.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(37, 22);
            this.btnin.Text = "In";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.toolStripLabel1.Image = global::S.BanHang.Properties.Resources.icons8_refresh_48;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "Làm mới";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem1,
            this.btnsua1,
            this.btnxoa1,
            this.btnin,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 72);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(405, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC HỢP ĐỒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cập nhật Hợp đồng - thêm, sửa, xóa, ...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.txttrangthai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 69);
            this.panel1.TabIndex = 10;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(455, 49);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(100, 20);
            this.txttrangthai.TabIndex = 14;
            this.txttrangthai.Text = "Báo giá";
            this.txttrangthai.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sobaogiaDataGridViewTextBoxColumn,
            this.tenbaogiaDataGridViewTextBoxColumn,
            this.ngaybaogiaDataGridViewTextBoxColumn,
            this.hieulucDataGridViewTextBoxColumn,
            this.thanhtienDataGridViewTextBoxColumn,
            this.makhDataGridViewTextBoxColumn,
            this.manhanvienDataGridViewTextBoxColumn,
            this.tongsoluongDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bAOGIAKHBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1339, 333);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // bAOGIAKHBindingSource1
            // 
            this.bAOGIAKHBindingSource1.DataMember = "BAOGIAKH";
            this.bAOGIAKHBindingSource1.DataSource = this._S_BaoGiaDataSetBGHopDong;
            // 
            // _S_BaoGiaDataSetBGHopDong
            // 
            this._S_BaoGiaDataSetBGHopDong.DataSetName = "_S_BaoGiaDataSetBGHopDong";
            this._S_BaoGiaDataSetBGHopDong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bAOGIAKHBindingSource
            // 
            this.bAOGIAKHBindingSource.DataMember = "BAOGIAKH";
            this.bAOGIAKHBindingSource.DataSource = this._S_BaoGiaDataSetBG;
            // 
            // _S_BaoGiaDataSetBG
            // 
            this._S_BaoGiaDataSetBG.DataSetName = "_S_BaoGiaDataSetBG";
            this._S_BaoGiaDataSetBG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lên hợp đồng từ báo giá";
            // 
            // bAOGIAKHTableAdapter
            // 
            this.bAOGIAKHTableAdapter.ClearBeforeFill = true;
            // 
            // bAOGIAKHTableAdapter1
            // 
            this.bAOGIAKHTableAdapter1.ClearBeforeFill = true;
            // 
            // sobaogiaDataGridViewTextBoxColumn
            // 
            this.sobaogiaDataGridViewTextBoxColumn.DataPropertyName = "sobaogia";
            this.sobaogiaDataGridViewTextBoxColumn.HeaderText = "Số báo giá";
            this.sobaogiaDataGridViewTextBoxColumn.Name = "sobaogiaDataGridViewTextBoxColumn";
            this.sobaogiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenbaogiaDataGridViewTextBoxColumn
            // 
            this.tenbaogiaDataGridViewTextBoxColumn.DataPropertyName = "tenbaogia";
            this.tenbaogiaDataGridViewTextBoxColumn.HeaderText = "Tên báo giá";
            this.tenbaogiaDataGridViewTextBoxColumn.Name = "tenbaogiaDataGridViewTextBoxColumn";
            this.tenbaogiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaybaogiaDataGridViewTextBoxColumn
            // 
            this.ngaybaogiaDataGridViewTextBoxColumn.DataPropertyName = "ngaybaogia";
            this.ngaybaogiaDataGridViewTextBoxColumn.HeaderText = "Ngày báo giá";
            this.ngaybaogiaDataGridViewTextBoxColumn.Name = "ngaybaogiaDataGridViewTextBoxColumn";
            this.ngaybaogiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaybaogiaDataGridViewTextBoxColumn.Width = 200;
            // 
            // hieulucDataGridViewTextBoxColumn
            // 
            this.hieulucDataGridViewTextBoxColumn.DataPropertyName = "hieuluc";
            this.hieulucDataGridViewTextBoxColumn.HeaderText = "Hiệu lực";
            this.hieulucDataGridViewTextBoxColumn.Name = "hieulucDataGridViewTextBoxColumn";
            this.hieulucDataGridViewTextBoxColumn.ReadOnly = true;
            this.hieulucDataGridViewTextBoxColumn.Width = 90;
            // 
            // thanhtienDataGridViewTextBoxColumn
            // 
            this.thanhtienDataGridViewTextBoxColumn.DataPropertyName = "thanhtien";
            this.thanhtienDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.thanhtienDataGridViewTextBoxColumn.Name = "thanhtienDataGridViewTextBoxColumn";
            this.thanhtienDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhtienDataGridViewTextBoxColumn.Width = 200;
            // 
            // makhDataGridViewTextBoxColumn
            // 
            this.makhDataGridViewTextBoxColumn.DataPropertyName = "makh";
            this.makhDataGridViewTextBoxColumn.HeaderText = "Khách hàng";
            this.makhDataGridViewTextBoxColumn.Name = "makhDataGridViewTextBoxColumn";
            this.makhDataGridViewTextBoxColumn.ReadOnly = true;
            this.makhDataGridViewTextBoxColumn.Width = 300;
            // 
            // manhanvienDataGridViewTextBoxColumn
            // 
            this.manhanvienDataGridViewTextBoxColumn.DataPropertyName = "manhanvien";
            this.manhanvienDataGridViewTextBoxColumn.HeaderText = "Nhân viên báo giá";
            this.manhanvienDataGridViewTextBoxColumn.Name = "manhanvienDataGridViewTextBoxColumn";
            this.manhanvienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongsoluongDataGridViewTextBoxColumn
            // 
            this.tongsoluongDataGridViewTextBoxColumn.DataPropertyName = "tongsoluong";
            this.tongsoluongDataGridViewTextBoxColumn.HeaderText = "Tổng số lượng mặt hàng";
            this.tongsoluongDataGridViewTextBoxColumn.Name = "tongsoluongDataGridViewTextBoxColumn";
            this.tongsoluongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangthaiDataGridViewTextBoxColumn
            // 
            this.trangthaiDataGridViewTextBoxColumn.DataPropertyName = "trangthai";
            this.trangthaiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangthaiDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Báo giá",
            "Hợp đồng",
            "Đóng"});
            this.trangthaiDataGridViewTextBoxColumn.Name = "trangthaiDataGridViewTextBoxColumn";
            this.trangthaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.trangthaiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangthaiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.trangthaiDataGridViewTextBoxColumn.Width = 110;
            // 
            // frhopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frhopdong";
            this.Text = "Frdonhang";
            this.Load += new System.EventHandler(this.frhopdong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOGIAKHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetBGHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOGIAKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel btnthem1;
        private System.Windows.Forms.ToolStripLabel btnsua1;
        private System.Windows.Forms.ToolStripLabel btnxoa1;
        private System.Windows.Forms.ToolStripLabel btnin;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private _S_BaoGiaDataSetBG _S_BaoGiaDataSetBG;
        private System.Windows.Forms.BindingSource bAOGIAKHBindingSource;
        private _S_BaoGiaDataSetBGTableAdapters.BAOGIAKHTableAdapter bAOGIAKHTableAdapter;
        private System.Windows.Forms.TextBox txttrangthai;
        private _S_BaoGiaDataSetBGHopDong _S_BaoGiaDataSetBGHopDong;
        private System.Windows.Forms.BindingSource bAOGIAKHBindingSource1;
        private _S_BaoGiaDataSetBGHopDongTableAdapters.BAOGIAKHTableAdapter bAOGIAKHTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobaogiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbaogiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybaogiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hieulucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongsoluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn trangthaiDataGridViewTextBoxColumn;
    }
}