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
    public partial class enquirybook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shreyas Tamboli\documents\visual studio 2013\Projects\smspi\smspi\smspidb.mdf;Integrated Security=True;Connect Timeout=30");
        public enquirybook()
        {
            InitializeComponent();
        }

        private void enquirybook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smspidbDataSet23.e_mst' table. You can move, or remove it, as needed.
            this.e_mstTableAdapter4.Fill(this.smspidbDataSet23.e_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet22.e_mst' table. You can move, or remove it, as needed.
           // this.e_mstTableAdapter3.Fill(this.smspidbDataSet22.e_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet16.e_mst' table. You can move, or remove it, as needed.
            //this.e_mstTableAdapter2.Fill(this.smspidbDataSet16.e_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet15.e_mst' table. You can move, or remove it, as needed.
            //this.e_mstTableAdapter1.Fill(this.smspidbDataSet15.e_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet8.e_mst' table. You can move, or remove it, as needed.
            //this.e_mstTableAdapter.Fill(this.smspidbDataSet8.e_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet6.Table4' table. You can move, or remove it, as needed.
           // this.table4TableAdapter.Fill(this.smspidbDataSet6.Table4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validation
            long mob;
            if(txtname.Text=="")
            {
                MessageBox.Show("Please Enter Student Nmae");
                txtname.Focus();
                return;
            }
            if(txtmobileno.Text=="")
            {
                MessageBox.Show("Please Enter Mobile No");
                txtmobileno.Focus();
                return;
            }
            if(txtemailid.Text=="")
            {
                MessageBox.Show("Please Enter Email Id");
                txtemailid.Focus();
                return;
            }
            if(txtintcourse.Text=="")
            {
                MessageBox.Show("Please Enter Course Name");
                txtintcourse.Focus();
                return;
            }
            if(comboref.SelectedItem =="")
            {
                MessageBox.Show("Please Enter refrence");
                comboref.Focus();
                return;
            }
            bool checkemail = Regex.IsMatch(txtemailid.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_'{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_'{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if(checkemail==true )
            {
                MessageBox.Show("Email in correct format");
            }
            else
            {
                MessageBox.Show("Email NOT in correct format");
                return;
            }
            if((!long.TryParse (txtmobileno.Text, out mob )) || (txtmobileno.Text.Length>10 || txtmobileno.Text.Length<10))
            {
                MessageBox.Show("Please Enter 10 Digits number");
                return;
            }
            //insert query
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into e_mst(name,mobileno,emailid,intersetedcourse,refrence,date) values('"+txtname.Text+"','"+txtmobileno.Text+"','"+txtemailid.Text+"','"+txtintcourse.Text+"','"+comboref.SelectedItem +"','"+dateTimePicker1.Value+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            txtname.Text = "";
            txtmobileno.Text = "";
            txtemailid.Text="";
            txtintcourse.Text="";
            comboref.SelectedItem = "";
            MessageBox.Show("record inserted successfully");
        }
        public void show()
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

        private void comboref_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtmobileno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8))
                e.Handled = true;
        }
    }
}
