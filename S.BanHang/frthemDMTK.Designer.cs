namespace S.BanHang
{
    partial class frthemDMTK
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
            this.btnluu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsotk = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttentk = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sBaoGiaDataSetDMTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._S_BaoGiaDataSetDMTK = new S.BanHang._S_BaoGiaDataSetDMTK();
            this.dANHMUCTAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dANHMUCTAIKHOANTableAdapter = new S.BanHang._S_BaoGiaDataSetDMTKTableAdapters.DANHMUCTAIKHOANTableAdapter();
            this.sotkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBaoGiaDataSetDMTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetDMTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCTAIKHOANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(274, 180);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 3;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM TÀI KHOẢN";
            // 
            // txtsotk
            // 
            this.txtsotk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotk.Location = new System.Drawing.Point(158, 69);
            this.txtsotk.Name = "txtsotk";
            this.txtsotk.Size = new System.Drawing.Size(191, 24);
            this.txtsotk.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 39);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(366, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(36, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên tài khoản:";
            // 
            // txttentk
            // 
            this.txttentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttentk.Location = new System.Drawing.Point(158, 114);
            this.txttentk.Multiline = true;
            this.txttentk.Name = "txttentk";
            this.txttentk.Size = new System.Drawing.Size(191, 31);
            this.txttentk.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sotkDataGridViewTextBoxColumn,
            this.tentkDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.coDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dANHMUCTAIKHOANBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(443, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(15, 24);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
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
            // dANHMUCTAIKHOANBindingSource
            // 
            this.dANHMUCTAIKHOANBindingSource.DataMember = "DANHMUCTAIKHOAN";
            this.dANHMUCTAIKHOANBindingSource.DataSource = this.sBaoGiaDataSetDMTKBindingSource;
            // 
            // dANHMUCTAIKHOANTableAdapter
            // 
            this.dANHMUCTAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // sotkDataGridViewTextBoxColumn
            // 
            this.sotkDataGridViewTextBoxColumn.DataPropertyName = "sotk";
            this.sotkDataGridViewTextBoxColumn.HeaderText = "sotk";
            this.sotkDataGridViewTextBoxColumn.Name = "sotkDataGridViewTextBoxColumn";
            // 
            // tentkDataGridViewTextBoxColumn
            // 
            this.tentkDataGridViewTextBoxColumn.DataPropertyName = "tentk";
            this.tentkDataGridViewTextBoxColumn.HeaderText = "tentk";
            this.tentkDataGridViewTextBoxColumn.Name = "tentkDataGridViewTextBoxColumn";
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "no";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // coDataGridViewTextBoxColumn
            // 
            this.coDataGridViewTextBoxColumn.DataPropertyName = "co";
            this.coDataGridViewTextBoxColumn.HeaderText = "co";
            this.coDataGridViewTextBoxColumn.Name = "coDataGridViewTextBoxColumn";
            // 
            // frthemDMTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 215);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttentk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsotk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnluu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frthemDMTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frthemDMTK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frthemDMTK_FormClosing);
            this.Load += new System.EventHandler(this.frthemDMTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBaoGiaDataSetDMTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetDMTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCTAIKHOANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsotk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttentk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sBaoGiaDataSetDMTKBindingSource;
        private _S_BaoGiaDataSetDMTK _S_BaoGiaDataSetDMTK;
        private System.Windows.Forms.BindingSource dANHMUCTAIKHOANBindingSource;
        private _S_BaoGiaDataSetDMTKTableAdapters.DANHMUCTAIKHOANTableAdapter dANHMUCTAIKHOANTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDataGridViewTextBoxColumn;
    }
}