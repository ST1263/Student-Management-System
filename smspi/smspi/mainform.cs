using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smspi
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            teacher t = new teacher();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            course c = new course();
            c.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labeldate.Text = dt.ToLongDateString();
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports r = new reports();
            r.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            techerreport tr = new techerreport();
            tr.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coursereport cr = new coursereport();
            cr.Show();
        }

        private void labeldate_Click(object sender, EventArgs e)
        {
        //    DateTime dt = DateTime.Now;
        //    labeldate.Text = dt.ToLongDateString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            enquirybook eb = new enquirybook();
            eb.Show();
        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enquiryreport er = new enquiryreport();
            er.Show();
        }
    }
}
