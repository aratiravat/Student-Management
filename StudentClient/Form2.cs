/*using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Check if the dataset and table exist
            /* if (StudentDataSet != null && StudentDataSet.Tables["Student"] != null)
            {
                // Set the DataSource of the DataGridView to the "Student" table
                dataGridView1.DataSource = StudentDataSet.Tables["Student"];
            }
            else
            {
                MessageBox.Show("Student dataset or table not found.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide Form
            this.Hide();

            // Create an instance of Form1
            Form3 form3 = new Form3();

            // Show Form1
            form3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentClient
{
    public partial class Form2 : Form
    {
        private StudentClient.ServiceReference1.Service1Client proxy;

        public Form2()
        {
            InitializeComponent();
            proxy = new StudentClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                // Retrieve all students from the service and convert the array to a list
                StudentClient.ServiceReference1.Student[] studentArray = proxy.AllStudents();
                List<StudentClient.ServiceReference1.Student> students = studentArray.ToList();

                // Bind the list of students to the DataGridView
                dataGridView1.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //update delete page
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();


            Form3 form3 = new Form3();


            form3.Show();
        }
        //homebutton
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
