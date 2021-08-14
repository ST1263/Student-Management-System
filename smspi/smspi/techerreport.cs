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
    public partial class techerreport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shreyas Tamboli\documents\visual studio 2013\Projects\smspi\smspi\smspidb.mdf;Integrated Security=True;Connect Timeout=30");
        public techerreport()
        {
            InitializeComponent();
        }

        private void techerreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smspidbDataSet11.T_mst' table. You can move, or remove it, as needed.
            this.t_mstTableAdapter.Fill(this.smspidbDataSet11.T_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet5.Table2' table. You can move, or remove it, as needed.
           // this.table2TableAdapter.Fill(this.smspidbDataSet5.Table2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from T_mst where teachername='" + textBox1.Text + "'";
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
            cmd.CommandText = "select * from T_mst";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);
            sqa.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
