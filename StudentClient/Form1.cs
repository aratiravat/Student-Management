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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   StudentClient.ServiceReference1.Service1Client proxy = new StudentClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");
              int stuId = int.Parse(textBox1.Text);
              string stuName = textBox2.Text;
              DateTime stuDOB = dateTimePicker1.Value;
              string education = textBox5.Text;
              int age = int.Parse(textBox3.Text);
              DateTime addDate = dateTimePicker2.Value;
              string address = textBox7.Text;

              StudentClient.ServiceReference1.Student student = new StudentClient.ServiceReference1.Student();
              student.StdId = stuId;
              student.Name = stuName;
              student.DOB = stuDOB;
              student.Education = education;
              student.Age = age;
              student.AddDate = addDate;
              student.Address = address;



              proxy.AddStudent(student);*/
            try
            {
                // Create an instance of the WCF service client
                StudentClient.ServiceReference1.Service1Client proxy = new StudentClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");

                // Gather data from input fields
                int stuId = int.Parse(textBox1.Text);
                string stuName = textBox2.Text;
                DateTime stuDOB = dateTimePicker1.Value;
                string education = textBox5.Text;
                int age = int.Parse(textBox3.Text);
                DateTime addDate = dateTimePicker2.Value;
                string address = textBox7.Text;

                // Create a Student object with the gathered data
                StudentClient.ServiceReference1.Student student = new StudentClient.ServiceReference1.Student();
                student.StdId = stuId;
                student.Name = stuName;
                student.DOB = stuDOB;
                student.Education = education;
                student.Age = age;
                student.AddDate = addDate;
                student.Address = address;

                proxy.AddStudent(student);

                // Since we cannot rely on the response, assume success
                MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the service client
                proxy.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //view student data
        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Hide();

        
            Form2 form2 = new Form2();

      
            form2.Show();
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
