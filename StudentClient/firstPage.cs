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
    public partial class firstPage : Form
    {
        public firstPage()
        {
            InitializeComponent();
        }
        //attendance page
        private void button2_Click(object sender, EventArgs e)
        {
            // Hide Form
            this.Hide();

            // Create an instance of Form1
            Attend attend = new Attend();

            // Show Form1
            attend.Show();

        }
        //Student redirect
        private void button1_Click(object sender, EventArgs e)
        {
            
                // Hide Form
                this.Hide();

                // Create an instance of Form1
                Form1 form1 = new Form1();

                // Show Form1
                form1.Show();
            

        }

        private void firstPage_Load(object sender, EventArgs e)
        {

        }
    }
}
