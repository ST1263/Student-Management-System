using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace smspi
{
    public partial class reports : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shreyas Tamboli\documents\visual studio 2013\Projects\smspi\smspi\smspidb.mdf;Integrated Security=True;Connect Timeout=30");
        public reports()
        {
            InitializeComponent();
        }

        private void reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smspidbDataSet18.s_mst' table. You can move, or remove it, as needed.
            this.s_mstTableAdapter1.Fill(this.smspidbDataSet18.s_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet12.s_mst' table. You can move, or remove it, as needed.
            //this.s_mstTableAdapter.Fill(this.smspidbDataSet12.s_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet4.Table3' table. You can move, or remove it, as needed.
            //this.table3TableAdapter.Fill(this.smspidbDataSet4.Table3);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from admission_mst where studentname='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);
            sqa.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Search successfully");
            //textBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.studentid,s.studentname,s.mobileno,t.coursename,t.fees,t.startdate from s_mst s,admission_mst t where s.studentid=t.studentid";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);
            sqa.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
