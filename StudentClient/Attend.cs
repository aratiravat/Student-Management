using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentClient
{
    public partial class Attend : Form
    {
        public StudentClient.ServiceReference1.Service1Client proxy;
        public Attend()
        {
            InitializeComponent();
            proxy = new StudentClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");
        }

        private void Attend_Load(object sender, EventArgs e)
        {
            try
            {
                // Retrieve all students from the service and convert the array to a list
                StudentClient.ServiceReference1.Attendance[] attendanceArray = proxy.AllAttendance();
                List<StudentClient.ServiceReference1.Attendance> attendance = attendanceArray.ToList();

                // Bind the list of students to the DataGridView
                dataGridView1.DataSource = attendance;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();


            AddA addA = new AddA();


            addA.Show();
        }
        //home button
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the form you want to navigate to
            firstPage firstPage = new firstPage();

            // Show the new form
            firstPage.Show();

            // Optionally, hide the current form
            this.Hide();
        }
    }
}
