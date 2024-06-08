using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentClient.ServiceReference1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentClient
{
    public partial class AddA : Form
    {
        public AddA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClient.ServiceReference1.Service1Client proxy = new StudentClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            int attendId = int.Parse(textBox1.Text);
            int stuId = int.Parse(textBox2.Text);
            string attendance = (textBox3.Text);
          

            StudentClient.ServiceReference1.Attendance attend = new StudentClient.ServiceReference1.Attendance();
            attend.AttendanceId = attendId;
            attend.StuId = stuId;
            attend.attendance = attendance;
           



            proxy.AddAttendance(attend);
        }

        private void AddA_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            StudentClient.ServiceReference1.Service1Client proxy = new StudentClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            int attendId = int.Parse(textBox1.Text);


            StudentClient.ServiceReference1.Attendance attend = new StudentClient.ServiceReference1.Attendance();
            attend.AttendanceId = attendId;




            proxy.DeleteAttendance(attendId);
        }
        //homebutton
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the form you want to navigate to
            firstPage firstPage = new firstPage();

            // Show the new form
            firstPage.Show();

            // Optionally, hide the current form
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the form you want to navigate to
            Attend attend = new Attend();

            // Show the new form
            attend.Show();

            // Optionally, hide the current form
            this.Hide();
        }
    }
}
