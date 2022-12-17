namespace S.BanHang
{
    partial class frbcdps
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._S_BaoGiaDataSetBCPS = new S.BanHang._S_BaoGiaDataSetBCPS();
            this.viewBCPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewBCPSTableAdapter = new S.BanHang._S_BaoGiaDataSetBCPSTableAdapters.ViewBCPSTableAdapter();
            this.sotkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodudkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soduckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetBCPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBCPSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sotkDataGridViewTextBoxColumn,
            this.sodudkDataGridViewTextBoxColumn,
            this.soduckDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewBCPSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // _S_BaoGiaDataSetBCPS
            // 
            this._S_BaoGiaDataSetBCPS.DataSetName = "_S_BaoGiaDataSetBCPS";
            this._S_BaoGiaDataSetBCPS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewBCPSBindingSource
            // 
            this.viewBCPSBindingSource.DataMember = "ViewBCPS";
            this.viewBCPSBindingSource.DataSource = this._S_BaoGiaDataSetBCPS;
            // 
            // viewBCPSTableAdapter
            // 
            this.viewBCPSTableAdapter.ClearBeforeFill = true;
            // 
            // sotkDataGridViewTextBoxColumn
            // 
            this.sotkDataGridViewTextBoxColumn.DataPropertyName = "sotk";
            this.sotkDataGridViewTextBoxColumn.HeaderText = "sotk";
            this.sotkDataGridViewTextBoxColumn.Name = "sotkDataGridViewTextBoxColumn";
            // 
            // sodudkDataGridViewTextBoxColumn
            // 
            this.sodudkDataGridViewTextBoxColumn.DataPropertyName = "sodudk";
            this.sodudkDataGridViewTextBoxColumn.HeaderText = "sodudk";
            this.sodudkDataGridViewTextBoxColumn.Name = "sodudkDataGridViewTextBoxColumn";
            // 
            // soduckDataGridViewTextBoxColumn
            // 
            this.soduckDataGridViewTextBoxColumn.DataPropertyName = "soduck";
            this.soduckDataGridViewTextBoxColumn.HeaderText = "soduck";
            this.soduckDataGridViewTextBoxColumn.Name = "soduckDataGridViewTextBoxColumn";
            // 
            // frbcdps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 477);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frbcdps";
            this.Text = "frbcdps";
            this.Load += new System.EventHandler(this.frbcdps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_BaoGiaDataSetBCPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBCPSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _S_BaoGiaDataSetBCPS _S_BaoGiaDataSetBCPS;
        private System.Windows.Forms.BindingSource viewBCPSBindingSource;
        private _S_BaoGiaDataSetBCPSTableAdapters.ViewBCPSTableAdapter viewBCPSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodudkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soduckDataGridViewTextBoxColumn;
    }
}