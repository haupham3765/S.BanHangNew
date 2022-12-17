namespace S.BanHang
{
    partial class frsuaDMTK
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
            this.dANHMUCTAIKHOANTableAdapter = new S.BanHang._S_BaoGiaDataSetDMTKTableAdapters.DANHMUCTAIKHOANTableAdapter();
            this.sBaoGiaDataSetDMTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._S_BaoGiaDataSetDMTK = new S.BanHang._S_BaoGiaDataSetDMTK();
            this.dANHMUCTAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsotk = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txttentk = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sBaoGiaDataSetDMTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetDMTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCTAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dANHMUCTAIKHOANTableAdapter
            // 
            this.dANHMUCTAIKHOANTableAdapter.ClearBeforeFill = true;
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
            // coDataGridViewTextBoxColumn
            // 
            this.coDataGridViewTextBoxColumn.DataPropertyName = "co";
            this.coDataGridViewTextBoxColumn.HeaderText = "co";
            this.coDataGridViewTextBoxColumn.Name = "coDataGridViewTextBoxColumn";
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "no";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // tentkDataGridViewTextBoxColumn
            // 
            this.tentkDataGridViewTextBoxColumn.DataPropertyName = "tentk";
            this.tentkDataGridViewTextBoxColumn.HeaderText = "tentk";
            this.tentkDataGridViewTextBoxColumn.Name = "tentkDataGridViewTextBoxColumn";
            // 
            // sotkDataGridViewTextBoxColumn
            // 
            this.sotkDataGridViewTextBoxColumn.DataPropertyName = "sotk";
            this.sotkDataGridViewTextBoxColumn.HeaderText = "sotk";
            this.sotkDataGridViewTextBoxColumn.Name = "sotkDataGridViewTextBoxColumn";
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
            this.dataGridView1.Location = new System.Drawing.Point(451, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(15, 24);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(44, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số tài khoản:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 39);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SỬA TÀI KHOẢN";
            // 
            // txtsotk
            // 
            this.txtsotk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotk.Location = new System.Drawing.Point(166, 77);
            this.txtsotk.Name = "txtsotk";
            this.txtsotk.Size = new System.Drawing.Size(191, 24);
            this.txtsotk.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(374, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txttentk
            // 
            this.txttentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttentk.Location = new System.Drawing.Point(166, 113);
            this.txttentk.Multiline = true;
            this.txttentk.Name = "txttentk";
            this.txttentk.Size = new System.Drawing.Size(191, 31);
            this.txttentk.TabIndex = 8;
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(282, 188);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 10;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // frsuaDMTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 252);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsotk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txttentk);
            this.Controls.Add(this.btnluu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frsuaDMTK";
            this.Text = "frsuaDMTK";
            ((System.ComponentModel.ISupportInitialize)(this.sBaoGiaDataSetDMTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetDMTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCTAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _S_BaoGiaDataSetDMTKTableAdapters.DANHMUCTAIKHOANTableAdapter dANHMUCTAIKHOANTableAdapter;
        private System.Windows.Forms.BindingSource sBaoGiaDataSetDMTKBindingSource;
        private _S_BaoGiaDataSetDMTK _S_BaoGiaDataSetDMTK;
        private System.Windows.Forms.BindingSource dANHMUCTAIKHOANBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsotk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txttentk;
        private System.Windows.Forms.Button btnluu;
    }
}