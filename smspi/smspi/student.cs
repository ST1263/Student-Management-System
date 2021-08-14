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
using System.Text.RegularExpressions;

namespace smspi
{
    public partial class student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shreyas Tamboli\documents\visual studio 2013\Projects\smspi\smspi\smspidb.mdf;Integrated Security=True;Connect Timeout=30");
        public student()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smspidbDataSet17.s_mst' table. You can move, or remove it, as needed.
            this.s_mstTableAdapter1.Fill(this.smspidbDataSet17.s_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet10.s_mst' table. You can move, or remove it, as needed.
            //this.s_mstTableAdapter.Fill(this.smspidbDataSet10.s_mst);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select coursename from c_mst",con);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            while (sdr1.Read())
            {
                comboBox1.Items.Add(sdr1[0]);
            }
            sdr1.Dispose();
            cmd1.Dispose();
            // TODO: This line of code loads data into the 'smspidbDataSet2.Table3' table. You can move, or remove it, as needed.
            //this.table3TableAdapter.Fill(this.smspidbDataSet2.Table3);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MAX(studentid) from s_mst";
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                string i = sdr[0].ToString();
                if (i == "")
                {
                    txtstudentid.Text = "1";
                }
                else
                {
                    txtstudentid.Text = (Convert.ToInt64(sdr[0].ToString()) + 1).ToString();
                }
            }
            sdr.Dispose();
            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validation
            if(txtstudentname.Text=="")
            {
                MessageBox.Show("Please Enetr Student Name");
                txtstudentname.Focus();
                return;
            }
            if(txtmobileno.Text=="")
            {
                MessageBox.Show("Please Enetr Mobile No.");
                txtmobileno.Focus();
                return;
            }
            if(txtemailid.Text=="")
            {
                MessageBox.Show("Please Enter Email id");
                txtemailid.Focus();
                return;
            }
            if(txtqualification.Text=="")
            {
                MessageBox.Show("Please Enter Qualification");
                txtqualification.Focus();
                return;
            }
            if(radioButton1.Checked==false && radioButton2.Checked==false )
            {
                MessageBox.Show("Please Enter gender");
                radioButton1.Focus();
                return;
            }
            if(comboBox1.SelectedItem=="")
            {
                MessageBox.Show("Please Enter Course Name ");
                comboBox1.Focus();
                return;
            }
            if(txtfees.Text=="")
            {
                MessageBox.Show("Please Enter Fee");
                txtfees.Focus();
                return;
            }
            if(txtaddress.Text=="")
            {
                MessageBox.Show("Please Enter Address");
                txtaddress.Focus();
                return;
            }
            bool checkemail = Regex.IsMatch(txtemailid.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_'{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_'{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (checkemail == true)
            {
                MessageBox.Show("Email in correct format");
            }
            else
            {
                MessageBox.Show("Email NOT in correct format");
                return;
            }
            string ma = "";
            if(!radioButton1.Capture )
            {
                ma = "female";
            }
            if(!radioButton2.Capture )
            {
                ma = "male";
            }
            //insert query
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into s_mst (studentname,mobileno,emailid,qualification,gender,dateofbirth,address)values('" + txtstudentname.Text + "','" + txtmobileno.Text + "','" + txtemailid.Text + "','" + txtqualification.Text + "','" + ma + "','" + dateTimePicker1.Value  + "','" + txtaddress.Text + "')";            
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into admission_mst (coursename,startdate,enddate,fees)values('" + comboBox1.Text + "','" + sdate.Value + "','" + edate.Value + "','" + txtfees.Text + "')";
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            show();
            clear();
            comboBox1.SelectedItem = "";
            txtfees.Text = "";
            MessageBox.Show("record inserted successfully");

        }
        public void show()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from s_mst";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);
            sqa.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
       public void clear()
        {
            txtstudentname.Text = "";
            txtmobileno.Text = "";
            txtemailid.Text = "";
            txtqualification.Text = "";
            txtaddress.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete query
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from s_mst where studentname='" + txtstudentname.Text+  "'";
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            clear();
            MessageBox.Show("record deleted successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = "";
            if (!radioButton1.Capture)
            {
                ma = "female";
            }
            if (!radioButton2.Capture)
            {
                ma = "male";
            }
            //updae query
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update s_mst set studentname= '" +txtstudentname.Text+ "', mobileno='"+txtmobileno.Text+"',emailid='"+txtemailid.Text+"',qualification='"+txtqualification.Text+"',gender='"+ma+"',dateofbirth='"+dateTimePicker1.Value +"',address='"+txtaddress.Text+"' where studentname='" + txtstudentname.Text  + "'";
            cmd.ExecuteNonQuery(); 
            con.Close();
            show();
            clear();
            MessageBox.Show("record updated successfully");
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string ma = "";
            if (!radioButton1.Capture)
            {
                ma = "female";
            }
            if (!radioButton2.Capture)
            {
                ma = "male";
            }
            int i = dataGridView1.CurrentCell.RowIndex;
            txtstudentname.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
            txtmobileno.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
            txtemailid.Text = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
            txtqualification.Text = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
            ma = Convert.ToString   (dataGridView1.Rows[i].Cells[5].Value);
            dateTimePicker1.Value  = Convert.ToDateTime (dataGridView1.Rows[i].Cells[6].Value);
            txtaddress.Text = Convert.ToString(dataGridView1.Rows[i].Cells[11].Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select coursefee from c_mst where coursename='" + comboBox1.SelectedItem  + "'", con);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    txtfees.Text = Convert.ToString(sdr1[0]);
                }
                sdr1.Dispose();
                cmd1.Dispose();
                con.Close();
        }

        private void txtstudentname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8))
                e.Handled = true;
        }

    }
}
