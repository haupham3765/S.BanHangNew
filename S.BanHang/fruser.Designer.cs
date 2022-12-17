namespace S.BanHang
{
    partial class fruser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthem1 = new System.Windows.Forms.ToolStripLabel();
            this.btnsua1 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoa1 = new System.Windows.Forms.ToolStripLabel();
            this.btnin = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1331, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 69);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Facebook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cập nhật hàng hóa, vật tư - thêm, sửa, xóa, ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC NGƯỜI SỬ DỤNG";
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
            this.toolStrip1.Size = new System.Drawing.Size(1355, 25);
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
            // fruser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1355, 538);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fruser";
            this.Text = "fruser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btnthem1;
        private System.Windows.Forms.ToolStripLabel btnsua1;
        private System.Windows.Forms.ToolStripLabel btnxoa1;
        private System.Windows.Forms.ToolStripLabel btnin;
    }
}