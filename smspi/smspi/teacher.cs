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
    public partial class teacher : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shreyas Tamboli\documents\visual studio 2013\Projects\smspi\smspi\smspidb.mdf;Integrated Security=True;Connect Timeout=30");
        public teacher()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validation
            if(txtteachername.Text=="")
            {
                MessageBox.Show("Please Enter Teacher Name");
                txtteachername.Focus();
                return;
            }
            if(txtqualification.Text=="")
            {
                MessageBox.Show("Please Enter Qualification");
                txtqualification.Focus();
                return;
            }
            if(txtexperiance.Text=="")
            {
                MessageBox.Show("Please Enter Experince");
                txtexperiance.Focus();
                return;
            }
            //insert query
            con.Open(); 
           SqlCommand cmd = con.CreateCommand();
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = "insert into T_mst (teachername,subject,qualification,joiningdate,experiance)values('"+txtteachername.Text+"','" + comboBox1.SelectedItem  + "','" + txtqualification.Text + "','" + dateTimePicker1.Value  + "','" + txtexperiance.Text + "')";
           cmd.ExecuteNonQuery();
           con.Close();
           show();
           MessageBox.Show("record inserted successfully");
           clear();
        }
        public void show()
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

        public void clear()
        {
            txtteachername.Text = "";
            comboBox1.SelectedItem = " ";
            txtqualification.Text = "";
            txtexperiance.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smspidbDataSet9.T_mst' table. You can move, or remove it, as needed.
            this.t_mstTableAdapter.Fill(this.smspidbDataSet9.T_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet1.Table2' table. You can move, or remove it, as needed.
            //this.table2TableAdapter.Fill(this.smspidbDataSet1.Table2);
           // con.Open();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select coursename from c_mst", con);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            while (sdr1.Read())
            {
                comboBox1.Items.Add(sdr1[0]);
            }
            sdr1.Dispose();
            cmd1.Dispose();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MAX(teacherid) from T_mst";
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                string i = sdr[0].ToString();
                if (i == "")
                {
                    txtteacherid.Text = "1";
                }
                else
                {
                    txtteacherid.Text = (Convert.ToInt64(sdr[0].ToString()) + 1).ToString();
                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update query
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update T_mst set subject='"+comboBox1.SelectedItem +"',qualification='"+txtqualification.Text+"',joiningdate='"+dateTimePicker1.Value +"',experiance='"+txtexperiance.Text+"' where teachername='"+txtteachername.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            clear();
            MessageBox.Show("record updated successfully");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete query
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from T_mst where teachername='"+txtteachername.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            
            MessageBox.Show("record deleted successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            txtteachername.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
            comboBox1.SelectedItem  = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
            txtqualification.Text = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
            dateTimePicker1.Value   = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
            txtexperiance.Text  = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
            
        }

        private void txtteachername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8))
                e.Handled = true;
        }
    }
}
