namespace S.BanHang
{
    partial class frdmtaikhoan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sotkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dANHMUCTAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sBaoGiaDataSetDMTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._S_BaoGiaDataSetDMTK = new S.BanHang._S_BaoGiaDataSetDMTK();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sotkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dunodkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ducodkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODUDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._S_BaoGiaDataSetSDDK = new S.BanHang._S_BaoGiaDataSetSDDK();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsotk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dANHMUCTAIKHOANTableAdapter = new S.BanHang._S_BaoGiaDataSetDMTKTableAdapters.DANHMUCTAIKHOANTableAdapter();
            this.sODUDKTableAdapter = new S.BanHang._S_BaoGiaDataSetSDDKTableAdapters.SODUDKTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthem1 = new System.Windows.Forms.ToolStripLabel();
            this.btnsua1 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoa1 = new System.Windows.Forms.ToolStripLabel();
            this.btnin = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCTAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBaoGiaDataSetDMTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetDMTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODUDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetSDDK)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sotkDataGridViewTextBoxColumn,
            this.tentkDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.coDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dANHMUCTAIKHOANBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1339, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // sotkDataGridViewTextBoxColumn
            // 
            this.sotkDataGridViewTextBoxColumn.DataPropertyName = "sotk";
            this.sotkDataGridViewTextBoxColumn.HeaderText = "Số tài khoản";
            this.sotkDataGridViewTextBoxColumn.Name = "sotkDataGridViewTextBoxColumn";
            this.sotkDataGridViewTextBoxColumn.ReadOnly = true;
            this.sotkDataGridViewTextBoxColumn.Width = 200;
            // 
            // tentkDataGridViewTextBoxColumn
            // 
            this.tentkDataGridViewTextBoxColumn.DataPropertyName = "tentk";
            this.tentkDataGridViewTextBoxColumn.HeaderText = "Tên tài khoản";
            this.tentkDataGridViewTextBoxColumn.Name = "tentkDataGridViewTextBoxColumn";
            this.tentkDataGridViewTextBoxColumn.ReadOnly = true;
            this.tentkDataGridViewTextBoxColumn.Width = 300;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "Nợ";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Width = 150;
            // 
            // coDataGridViewTextBoxColumn
            // 
            this.coDataGridViewTextBoxColumn.DataPropertyName = "co";
            this.coDataGridViewTextBoxColumn.HeaderText = "Có";
            this.coDataGridViewTextBoxColumn.Name = "coDataGridViewTextBoxColumn";
            this.coDataGridViewTextBoxColumn.ReadOnly = true;
            this.coDataGridViewTextBoxColumn.Width = 150;
            // 
            // dANHMUCTAIKHOANBindingSource
            // 
            this.dANHMUCTAIKHOANBindingSource.DataMember = "DANHMUCTAIKHOAN";
            this.dANHMUCTAIKHOANBindingSource.DataSource = this.sBaoGiaDataSetDMTKBindingSource;
            // 
            // sBaoGiaDataSetDMTKBindingSource
            // 
            this.sBaoGiaDataSetDMTKBindingSource.DataSource = this._S_BaoGiaDataSetDMTK;
            this.sBaoGiaDataSetDMTKBindingSource.Position = 0;
            // 
            // _S_BaoGiaDataSetDMTK
            // 
            this._S_BaoGiaDataSetDMTK.DataSetName = "_S_BaoGiaDataSetDMTK";
            this._S_BaoGiaDataSetDMTK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sotkDataGridViewTextBoxColumn1,
            this.dunodkDataGridViewTextBoxColumn,
            this.ducodkDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sODUDKBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 372);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1339, 175);
            this.dataGridView2.TabIndex = 1;
            // 
            // sotkDataGridViewTextBoxColumn1
            // 
            this.sotkDataGridViewTextBoxColumn1.DataPropertyName = "sotk";
            this.sotkDataGridViewTextBoxColumn1.HeaderText = "Số tài khoản";
            this.sotkDataGridViewTextBoxColumn1.Name = "sotkDataGridViewTextBoxColumn1";
            this.sotkDataGridViewTextBoxColumn1.Width = 200;
            // 
            // dunodkDataGridViewTextBoxColumn
            // 
            this.dunodkDataGridViewTextBoxColumn.DataPropertyName = "dunodk";
            this.dunodkDataGridViewTextBoxColumn.HeaderText = "Dư nợ đầu kỳ";
            this.dunodkDataGridViewTextBoxColumn.Name = "dunodkDataGridViewTextBoxColumn";
            this.dunodkDataGridViewTextBoxColumn.Width = 450;
            // 
            // ducodkDataGridViewTextBoxColumn
            // 
            this.ducodkDataGridViewTextBoxColumn.DataPropertyName = "ducodk";
            this.ducodkDataGridViewTextBoxColumn.HeaderText = "Dư có đầu kỳ";
            this.ducodkDataGridViewTextBoxColumn.Name = "ducodkDataGridViewTextBoxColumn";
            this.ducodkDataGridViewTextBoxColumn.Width = 450;
            // 
            // sODUDKBindingSource
            // 
            this.sODUDKBindingSource.DataMember = "SODUDK";
            this.sODUDKBindingSource.DataSource = this._S_BaoGiaDataSetSDDK;
            // 
            // _S_BaoGiaDataSetSDDK
            // 
            this._S_BaoGiaDataSetSDDK.DataSetName = "_S_BaoGiaDataSetSDDK";
            this._S_BaoGiaDataSetSDDK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.txtsotk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 69);
            this.panel1.TabIndex = 3;
            // 
            // txtsotk
            // 
            this.txtsotk.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dANHMUCTAIKHOANBindingSource, "sotk", true));
            this.txtsotk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dANHMUCTAIKHOANBindingSource, "sotk", true));
            this.txtsotk.Location = new System.Drawing.Point(509, 31);
            this.txtsotk.Name = "txtsotk";
            this.txtsotk.Size = new System.Drawing.Size(100, 20);
            this.txtsotk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cập nhật tài khoản kế toán - thêm, sửa, xóa, ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC TÀI KHOẢN KẾ TOÁN";
            // 
            // dANHMUCTAIKHOANTableAdapter
            // 
            this.dANHMUCTAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // sODUDKTableAdapter
            // 
            this.sODUDKTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem1,
            this.btnsua1,
            this.btnxoa1,
            this.btnin,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 69);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1363, 25);
            this.toolStrip1.TabIndex = 9;
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.toolStripLabel1.Image = global::S.BanHang.Properties.Resources.icons8_refresh_48;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "Làm mới";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // frdmtaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1363, 550);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frdmtaikhoan";
            this.Text = "frdmtaikhoan";
            this.Load += new System.EventHandler(this.frdmtaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCTAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBaoGiaDataSetDMTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetDMTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODUDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetSDDK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sBaoGiaDataSetDMTKBindingSource;
        private _S_BaoGiaDataSetDMTK _S_BaoGiaDataSetDMTK;
        private System.Windows.Forms.BindingSource dANHMUCTAIKHOANBindingSource;
        private _S_BaoGiaDataSetDMTKTableAdapters.DANHMUCTAIKHOANTableAdapter dANHMUCTAIKHOANTableAdapter;
        private _S_BaoGiaDataSetSDDK _S_BaoGiaDataSetSDDK;
        private System.Windows.Forms.BindingSource sODUDKBindingSource;
        private _S_BaoGiaDataSetSDDKTableAdapters.SODUDKTableAdapter sODUDKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btnthem1;
        private System.Windows.Forms.ToolStripLabel btnsua1;
        private System.Windows.Forms.ToolStripLabel btnxoa1;
        private System.Windows.Forms.ToolStripLabel btnin;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dunodkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ducodkDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox txtsotk;
    }
}