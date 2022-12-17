namespace S.BanHang
{
    partial class TEST
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._S_BaoGiaDataSetHH = new S.BanHang._S_BaoGiaDataSetHH();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOATableAdapter = new S.BanHang._S_BaoGiaDataSetHHTableAdapters.HANGHOATableAdapter();
            this.dataGridViewchinh = new System.Windows.Forms.DataGridView();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMH = new System.Windows.Forms.DataGridView();
            this.tenhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this._S_BaoGiaDataSetBGtemp = new S.BanHang._S_BaoGiaDataSetBGtemp();
            this.bAOGIAtempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAOGIAtempTableAdapter = new S.BanHang._S_BaoGiaDataSetBGtempTableAdapters.BAOGIAtempTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sobaogiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetBGtemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOGIAtempBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _S_BaoGiaDataSetHH
            // 
            this._S_BaoGiaDataSetHH.DataSetName = "_S_BaoGiaDataSetHH";
            this._S_BaoGiaDataSetHH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this._S_BaoGiaDataSetHH;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewchinh
            // 
            this.dataGridViewchinh.AutoGenerateColumns = false;
            this.dataGridViewchinh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewchinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewchinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenhang,
            this.soluong,
            this.giaban,
            this.thanhtien,
            this.mahh,
            this.sobg,
            this.sobaogiaDataGridViewTextBoxColumn,
            this.tenhhDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn1,
            this.thanhtienDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn1});
            this.dataGridViewchinh.DataSource = this.bAOGIAtempBindingSource;
            this.dataGridViewchinh.Location = new System.Drawing.Point(12, 159);
            this.dataGridViewchinh.Name = "dataGridViewchinh";
            this.dataGridViewchinh.Size = new System.Drawing.Size(927, 225);
            this.dataGridViewchinh.TabIndex = 21;
            // 
            // tenhang
            // 
            this.tenhang.DataPropertyName = "tenhang";
            this.tenhang.HeaderText = "Tên Hàng";
            this.tenhang.Name = "tenhang";
            this.tenhang.Width = 300;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 60;
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "giaban";
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            this.giaban.Width = 160;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.thanhtien.DefaultCellStyle = dataGridViewCellStyle1;
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 167;
            // 
            // mahh
            // 
            this.mahh.DataPropertyName = "mahang";
            this.mahh.HeaderText = "Mã";
            this.mahh.Name = "mahh";
            // 
            // sobg
            // 
            this.sobg.DataPropertyName = "sobg";
            this.sobg.HeaderText = "sogb";
            this.sobg.Name = "sobg";
            // 
            // dataGridViewMH
            // 
            this.dataGridViewMH.AllowUserToAddRows = false;
            this.dataGridViewMH.AllowUserToDeleteRows = false;
            this.dataGridViewMH.AllowUserToResizeColumns = false;
            this.dataGridViewMH.AllowUserToResizeRows = false;
            this.dataGridViewMH.AutoGenerateColumns = false;
            this.dataGridViewMH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenhangDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.mahang});
            this.dataGridViewMH.DataSource = this.hANGHOABindingSource;
            this.dataGridViewMH.Location = new System.Drawing.Point(325, 12);
            this.dataGridViewMH.MultiSelect = false;
            this.dataGridViewMH.Name = "dataGridViewMH";
            this.dataGridViewMH.ReadOnly = true;
            this.dataGridViewMH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewMH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMH.ShowCellErrors = false;
            this.dataGridViewMH.ShowCellToolTips = false;
            this.dataGridViewMH.ShowEditingIcon = false;
            this.dataGridViewMH.ShowRowErrors = false;
            this.dataGridViewMH.Size = new System.Drawing.Size(533, 126);
            this.dataGridViewMH.TabIndex = 22;
            // 
            // tenhangDataGridViewTextBoxColumn
            // 
            this.tenhangDataGridViewTextBoxColumn.DataPropertyName = "tenhang";
            this.tenhangDataGridViewTextBoxColumn.HeaderText = "Tên mặt hàng";
            this.tenhangDataGridViewTextBoxColumn.Name = "tenhangDataGridViewTextBoxColumn";
            this.tenhangDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenhangDataGridViewTextBoxColumn.Width = 300;
            // 
            // giabanDataGridViewTextBoxColumn
            // 
            this.giabanDataGridViewTextBoxColumn.DataPropertyName = "giaban";
            dataGridViewCellStyle2.Format = "N0";
            this.giabanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.giabanDataGridViewTextBoxColumn.HeaderText = "giaban";
            this.giabanDataGridViewTextBoxColumn.Name = "giabanDataGridViewTextBoxColumn";
            this.giabanDataGridViewTextBoxColumn.ReadOnly = true;
            this.giabanDataGridViewTextBoxColumn.Width = 90;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "soluong";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mahang
            // 
            this.mahang.DataPropertyName = "mahang";
            this.mahang.HeaderText = "mahangê";
            this.mahang.Name = "mahang";
            this.mahang.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _S_BaoGiaDataSetBGtemp
            // 
            this._S_BaoGiaDataSetBGtemp.DataSetName = "_S_BaoGiaDataSetBGtemp";
            this._S_BaoGiaDataSetBGtemp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bAOGIAtempBindingSource
            // 
            this.bAOGIAtempBindingSource.DataMember = "BAOGIAtemp";
            this.bAOGIAtempBindingSource.DataSource = this._S_BaoGiaDataSetBGtemp;
            // 
            // bAOGIAtempTableAdapter
            // 
            this.bAOGIAtempTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 24;
            // 
            // sobaogiaDataGridViewTextBoxColumn
            // 
            this.sobaogiaDataGridViewTextBoxColumn.DataPropertyName = "sobaogia";
            this.sobaogiaDataGridViewTextBoxColumn.HeaderText = "sobaogia";
            this.sobaogiaDataGridViewTextBoxColumn.Name = "sobaogiaDataGridViewTextBoxColumn";
            // 
            // tenhhDataGridViewTextBoxColumn
            // 
            this.tenhhDataGridViewTextBoxColumn.DataPropertyName = "tenhh";
            this.tenhhDataGridViewTextBoxColumn.HeaderText = "tenhh";
            this.tenhhDataGridViewTextBoxColumn.Name = "tenhhDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn1
            // 
            this.soluongDataGridViewTextBoxColumn1.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn1.HeaderText = "soluong";
            this.soluongDataGridViewTextBoxColumn1.Name = "soluongDataGridViewTextBoxColumn1";
            // 
            // thanhtienDataGridViewTextBoxColumn
            // 
            this.thanhtienDataGridViewTextBoxColumn.DataPropertyName = "thanhtien";
            this.thanhtienDataGridViewTextBoxColumn.HeaderText = "thanhtien";
            this.thanhtienDataGridViewTextBoxColumn.Name = "thanhtienDataGridViewTextBoxColumn";
            // 
            // giabanDataGridViewTextBoxColumn1
            // 
            this.giabanDataGridViewTextBoxColumn1.DataPropertyName = "giaban";
            this.giabanDataGridViewTextBoxColumn1.HeaderText = "giaban";
            this.giabanDataGridViewTextBoxColumn1.Name = "giabanDataGridViewTextBoxColumn1";
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewchinh);
            this.Controls.Add(this.dataGridViewMH);
            this.Name = "TEST";
            this.Text = "TEST";
            this.Load += new System.EventHandler(this.TEST_Load);
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetBGtemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOGIAtempBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private _S_BaoGiaDataSetHH _S_BaoGiaDataSetHH;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private _S_BaoGiaDataSetHHTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewchinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobg;
        private System.Windows.Forms.DataGridView dataGridViewMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahang;
        private System.Windows.Forms.Button button1;
        private _S_BaoGiaDataSetBGtemp _S_BaoGiaDataSetBGtemp;
        private System.Windows.Forms.BindingSource bAOGIAtempBindingSource;
        private _S_BaoGiaDataSetBGtempTableAdapters.BAOGIAtempTableAdapter bAOGIAtempTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobaogiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn1;
    }
}