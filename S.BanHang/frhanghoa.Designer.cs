namespace S.BanHang
{
    partial class frhanghoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMH = new System.Windows.Forms.DataGridView();
            this.mahangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giavonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatxuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._S_BaoGiaDataSetHH = new S.BanHang._S_BaoGiaDataSetHH();
            this.txtmahh = new System.Windows.Forms.TextBox();
            this.hANGHOATableAdapter = new S.BanHang._S_BaoGiaDataSetHHTableAdapters.HANGHOATableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthem1 = new System.Windows.Forms.ToolStripLabel();
            this.btnsua1 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoa1 = new System.Windows.Forms.ToolStripLabel();
            this.btnin = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetHH)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC HÀNG HÓA, VẬT TƯ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 69);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cập nhật hàng hóa, vật tư - thêm, sửa, xóa, ...";
            // 
            // dataGridViewMH
            // 
            this.dataGridViewMH.AllowDrop = true;
            this.dataGridViewMH.AllowUserToResizeColumns = false;
            this.dataGridViewMH.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewMH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMH.AutoGenerateColumns = false;
            this.dataGridViewMH.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewMH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMH.ColumnHeadersHeight = 30;
            this.dataGridViewMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahangDataGridViewTextBoxColumn,
            this.tenhangDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.dvtDataGridViewTextBoxColumn,
            this.giavonDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn,
            this.xuatxuDataGridViewTextBoxColumn,
            this.sotk});
            this.dataGridViewMH.DataSource = this.hANGHOABindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMH.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMH.GridColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewMH.Location = new System.Drawing.Point(0, 115);
            this.dataGridViewMH.MultiSelect = false;
            this.dataGridViewMH.Name = "dataGridViewMH";
            this.dataGridViewMH.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMH.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMH.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMH.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMH.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMH.Size = new System.Drawing.Size(1363, 465);
            this.dataGridViewMH.TabIndex = 3;
            // 
            // mahangDataGridViewTextBoxColumn
            // 
            this.mahangDataGridViewTextBoxColumn.DataPropertyName = "mahang";
            this.mahangDataGridViewTextBoxColumn.HeaderText = "Mã Hàng";
            this.mahangDataGridViewTextBoxColumn.Name = "mahangDataGridViewTextBoxColumn";
            this.mahangDataGridViewTextBoxColumn.ReadOnly = true;
            this.mahangDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenhangDataGridViewTextBoxColumn
            // 
            this.tenhangDataGridViewTextBoxColumn.DataPropertyName = "tenhang";
            this.tenhangDataGridViewTextBoxColumn.HeaderText = "Tên Hàng";
            this.tenhangDataGridViewTextBoxColumn.Name = "tenhangDataGridViewTextBoxColumn";
            this.tenhangDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenhangDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenhangDataGridViewTextBoxColumn.Width = 500;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số Lượng tồn";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soluongDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dvtDataGridViewTextBoxColumn
            // 
            this.dvtDataGridViewTextBoxColumn.DataPropertyName = "dvt";
            this.dvtDataGridViewTextBoxColumn.HeaderText = "ĐVT";
            this.dvtDataGridViewTextBoxColumn.Name = "dvtDataGridViewTextBoxColumn";
            this.dvtDataGridViewTextBoxColumn.ReadOnly = true;
            this.dvtDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // giavonDataGridViewTextBoxColumn
            // 
            this.giavonDataGridViewTextBoxColumn.DataPropertyName = "giavon";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.giavonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.giavonDataGridViewTextBoxColumn.HeaderText = "Giá Vốn";
            this.giavonDataGridViewTextBoxColumn.Name = "giavonDataGridViewTextBoxColumn";
            this.giavonDataGridViewTextBoxColumn.ReadOnly = true;
            this.giavonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.giavonDataGridViewTextBoxColumn.Width = 150;
            // 
            // giabanDataGridViewTextBoxColumn
            // 
            this.giabanDataGridViewTextBoxColumn.DataPropertyName = "giaban";
            dataGridViewCellStyle4.Format = "N0";
            this.giabanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.giabanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            this.giabanDataGridViewTextBoxColumn.Name = "giabanDataGridViewTextBoxColumn";
            this.giabanDataGridViewTextBoxColumn.ReadOnly = true;
            this.giabanDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.giabanDataGridViewTextBoxColumn.Width = 150;
            // 
            // xuatxuDataGridViewTextBoxColumn
            // 
            this.xuatxuDataGridViewTextBoxColumn.DataPropertyName = "xuatxu";
            this.xuatxuDataGridViewTextBoxColumn.HeaderText = "Xuất Xứ";
            this.xuatxuDataGridViewTextBoxColumn.Name = "xuatxuDataGridViewTextBoxColumn";
            this.xuatxuDataGridViewTextBoxColumn.ReadOnly = true;
            this.xuatxuDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.xuatxuDataGridViewTextBoxColumn.Width = 118;
            // 
            // sotk
            // 
            this.sotk.DataPropertyName = "sotk";
            this.sotk.HeaderText = "TK Vật tư";
            this.sotk.Name = "sotk";
            this.sotk.ReadOnly = true;
            this.sotk.Width = 150;
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this._S_BaoGiaDataSetHH;
            // 
            // _S_BaoGiaDataSetHH
            // 
            this._S_BaoGiaDataSetHH.DataSetName = "_S_BaoGiaDataSetHH";
            this._S_BaoGiaDataSetHH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtmahh
            // 
            this.txtmahh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hANGHOABindingSource, "mahang", true));
            this.txtmahh.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.hANGHOABindingSource, "mahang", true));
            this.txtmahh.Location = new System.Drawing.Point(0, 190);
            this.txtmahh.Name = "txtmahh";
            this.txtmahh.Size = new System.Drawing.Size(71, 20);
            this.txtmahh.TabIndex = 5;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTH);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1363, 23);
            this.panel2.TabIndex = 7;
            // 
            // lbTH
            // 
            this.lbTH.AutoSize = true;
            this.lbTH.Location = new System.Drawing.Point(884, 5);
            this.lbTH.Name = "lbTH";
            this.lbTH.Size = new System.Drawing.Size(21, 13);
            this.lbTH.TabIndex = 8;
            this.lbTH.Text = "TT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(782, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng số mặt hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "App xây dựng bởi Công Hậu";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem1,
            this.btnsua1,
            this.btnxoa1,
            this.btnin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 69);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1363, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnthem1
            // 
            this.btnthem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem1.Image = global::S.BanHang.Properties.Resources.add_file;
            this.btnthem1.Name = "btnthem1";
            this.btnthem1.Size = new System.Drawing.Size(92, 22);
            this.btnthem1.Text = "Thêm mới";
            this.btnthem1.Click += new System.EventHandler(this.btnthem1_Click);
            // 
            // btnsua1
            // 
            this.btnsua1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua1.Image = global::S.BanHang.Properties.Resources.writing;
            this.btnsua1.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnsua1.Name = "btnsua1";
            this.btnsua1.Size = new System.Drawing.Size(50, 22);
            this.btnsua1.Text = "Sửa";
            this.btnsua1.Click += new System.EventHandler(this.btnsua1_Click);
            // 
            // btnxoa1
            // 
            this.btnxoa1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa1.Image = global::S.BanHang.Properties.Resources.delete;
            this.btnxoa1.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnxoa1.Name = "btnxoa1";
            this.btnxoa1.Size = new System.Drawing.Size(51, 22);
            this.btnxoa1.Text = "Xóa";
            this.btnxoa1.Click += new System.EventHandler(this.btnxoa1_Click);
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
            // frhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1363, 502);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewMH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtmahh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frhanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frhanghoa";
            this.Load += new System.EventHandler(this.frhanghoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetHH)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private _S_BaoGiaDataSetHH _S_BaoGiaDataSetHH;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private _S_BaoGiaDataSetHHTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewMH;
        private System.Windows.Forms.TextBox txtmahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giavonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuatxuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTH;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btnthem1;
        private System.Windows.Forms.ToolStripLabel btnsua1;
        private System.Windows.Forms.ToolStripLabel btnxoa1;
        private System.Windows.Forms.ToolStripLabel btnin;
    }
}