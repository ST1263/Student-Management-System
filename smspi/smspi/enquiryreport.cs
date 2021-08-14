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
    public partial class enquiryreport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shreyas Tamboli\Documents\Visual Studio 2013\Projects\smspi\smspi\smspidb.mdf;Integrated Security=True;Connect Timeout=30");
        public enquiryreport()
        {
            InitializeComponent();
        }

        private void enquiryreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smspidbDataSet21.e_mst' table. You can move, or remove it, as needed.
            this.e_mstTableAdapter1.Fill(this.smspidbDataSet21.e_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet7.e_mst' table. You can move, or remove it, as needed.
            //this.e_mstTableAdapter.Fill(this.smspidbDataSet7.e_mst);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from e_mst where date='" + dateTimePicker1.Value  + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);
            sqa.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Search successfully");
            //textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from e_mst";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);
            sqa.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
