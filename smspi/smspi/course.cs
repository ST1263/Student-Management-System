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
    public partial class course : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shreyas Tamboli\Documents\Visual Studio 2013\Projects\smspi\smspi\smspidb.mdf;Integrated Security=True;Connect Timeout=30");
        public course()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smspidbDataSet13.c_mst' table. You can move, or remove it, as needed.
            this.c_mstTableAdapter.Fill(this.smspidbDataSet13.c_mst);
            // TODO: This line of code loads data into the 'smspidbDataSet.Table1' table. You can move, or remove it, as needed.
            //this.table1TableAdapter.Fill(this.smspidbDataSet.Table1);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MAX(courseid) from c_mst";
             SqlDataReader  sdr = cmd.ExecuteReader();
             if(sdr.Read())
             {
                     string i = sdr[0].ToString();
                     if(i=="")
                     {
                         txtcourseid.Text = "1";
                     }
                    else
                    {
                         txtcourseid.Text = (Convert.ToInt64(sdr[0].ToString()) + 1).ToString();
                    }
             }
            con.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //validation
            if(txtcoursename.Text=="")
            {
                MessageBox.Show("Please Enter Course name");
                txtcoursename.Focus();
                return;
            }
            if(txtcoursefee.Text=="")
            {
                MessageBox.Show("Please Enter Course Fee");
                txtcoursefee.Focus();
                return;
            }
            if(txtduration.Text=="")
            {
                MessageBox.Show("Please Enter Duration");
                txtduration.Focus();
                return;
            }
            //validation end 
            //insert query
            con.Open(); 
           SqlCommand cmd = con.CreateCommand();
           cmd.CommandType = CommandType.Text;
            cmd.CommandText="insert into c_mst (coursename,coursefee,duration) values('"+txtcoursename.Text+"','"+txtcoursefee.Text+"','"+txtduration.Text +"')";
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
           cmd.CommandText = "select * from c_mst";
           cmd.ExecuteNonQuery();
           DataTable dt = new DataTable();
           SqlDataAdapter sqa = new SqlDataAdapter(cmd);
           sqa.Fill(dt);
           dataGridView1.DataSource = dt;
           con.Close();
       }

        public void clear()
               {
                   txtcoursename.Text = "";
                   txtcoursefee.Text = "";
                   txtduration.Text = "";

               }
        private void button3_Click(object sender, EventArgs e)
        {
            //delete query
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from c_mst where coursename='" +txtcoursename.Text  + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            MessageBox.Show("record deleted successfully");
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update query
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update c_mst set coursefee= '"+txtcoursefee.Text+"',duration='"+txtduration.Text+"' where coursename='" + txtcoursename.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            MessageBox.Show("record updated successfully");
            clear();


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            txtcoursename.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
            txtcoursefee.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
            txtduration.Text = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
            
        }

        private void txtcourseid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcoursename_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcoursename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8))
                e.Handled = true;
        }
    }
}
