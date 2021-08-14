namespace smspi
{
    partial class reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.smstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smspidbDataSet12 = new smspi.smspidbDataSet12();
            this.table3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smspidbDataSet4 = new smspi.smspidbDataSet4();
            this.table3TableAdapter = new smspi.smspidbDataSet4TableAdapters.Table3TableAdapter();
            this.s_mstTableAdapter = new smspi.smspidbDataSet12TableAdapters.s_mstTableAdapter();
            this.smspidbDataSet18 = new smspi.smspidbDataSet18();
            this.smstBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.s_mstTableAdapter1 = new smspi.smspidbDataSet18TableAdapters.s_mstTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smspidbDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smspidbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smspidbDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smstBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Reports";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(338, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(254, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "All Records";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Student Name";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(407, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 33);
            this.button4.TabIndex = 2;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(618, 253);
            this.dataGridView1.TabIndex = 2;
            // 
            // smstBindingSource
            // 
            this.smstBindingSource.DataMember = "s_mst";
            this.smstBindingSource.DataSource = this.smspidbDataSet12;
            // 
            // smspidbDataSet12
            // 
            this.smspidbDataSet12.DataSetName = "smspidbDataSet12";
            this.smspidbDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table3BindingSource
            // 
            this.table3BindingSource.DataMember = "Table3";
            this.table3BindingSource.DataSource = this.smspidbDataSet4;
            // 
            // smspidbDataSet4
            // 
            this.smspidbDataSet4.DataSetName = "smspidbDataSet4";
            this.smspidbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table3TableAdapter
            // 
            this.table3TableAdapter.ClearBeforeFill = true;
            // 
            // s_mstTableAdapter
            // 
            this.s_mstTableAdapter.ClearBeforeFill = true;
            // 
            // smspidbDataSet18
            // 
            this.smspidbDataSet18.DataSetName = "smspidbDataSet18";
            this.smspidbDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smstBindingSource1
            // 
            this.smstBindingSource1.DataMember = "s_mst";
            this.smstBindingSource1.DataSource = this.smspidbDataSet18;
            // 
            // s_mstTableAdapter1
            // 
            this.s_mstTableAdapter1.ClearBeforeFill = true;
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1370, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reports";
            this.Text = "reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reports_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smspidbDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smspidbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smspidbDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smstBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private smspidbDataSet4 smspidbDataSet4;
        private System.Windows.Forms.BindingSource table3BindingSource;
        private smspidbDataSet4TableAdapters.Table3TableAdapter table3TableAdapter;
        private System.Windows.Forms.Button button1;
        private smspidbDataSet12 smspidbDataSet12;
        private System.Windows.Forms.BindingSource smstBindingSource;
        private smspidbDataSet12TableAdapters.s_mstTableAdapter s_mstTableAdapter;
        private smspidbDataSet18 smspidbDataSet18;
        private System.Windows.Forms.BindingSource smstBindingSource1;
        private smspidbDataSet18TableAdapters.s_mstTableAdapter s_mstTableAdapter1;
    }
}