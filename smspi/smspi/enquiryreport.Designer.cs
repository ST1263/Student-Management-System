namespace smspi
{
    partial class enquiryreport
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emstBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.smspidbDataSet21 = new smspi.smspidbDataSet21();
            this.emstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smspidbDataSet7 = new smspi.smspidbDataSet7();
            this.e_mstTableAdapter = new smspi.smspidbDataSet7TableAdapters.e_mstTableAdapter();
            this.e_mstTableAdapter1 = new smspi.smspidbDataSet21TableAdapters.e_mstTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emstBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smspidbDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smspidbDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(389, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enquiry Reports";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(337, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enquiry";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(218, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "All Records";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(360, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 165);
            this.dataGridView1.TabIndex = 2;
            // 
            // emstBindingSource1
            // 
            this.emstBindingSource1.DataMember = "e_mst";
            this.emstBindingSource1.DataSource = this.smspidbDataSet21;
            // 
            // smspidbDataSet21
            // 
            this.smspidbDataSet21.DataSetName = "smspidbDataSet21";
            this.smspidbDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emstBindingSource
            // 
            this.emstBindingSource.DataMember = "e_mst";
            this.emstBindingSource.DataSource = this.smspidbDataSet7;
            // 
            // smspidbDataSet7
            // 
            this.smspidbDataSet7.DataSetName = "smspidbDataSet7";
            this.smspidbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_mstTableAdapter
            // 
            this.e_mstTableAdapter.ClearBeforeFill = true;
            // 
            // e_mstTableAdapter1
            // 
            this.e_mstTableAdapter1.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // enquiryreport
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
            this.Name = "enquiryreport";
            this.Text = "enquiryreport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.enquiryreport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emstBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smspidbDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smspidbDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private smspidbDataSet7 smspidbDataSet7;
        private System.Windows.Forms.BindingSource emstBindingSource;
        private smspidbDataSet7TableAdapters.e_mstTableAdapter e_mstTableAdapter;
        private smspidbDataSet21 smspidbDataSet21;
        private System.Windows.Forms.BindingSource emstBindingSource1;
        private smspidbDataSet21TableAdapters.e_mstTableAdapter e_mstTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}