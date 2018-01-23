using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Admin_Login_Form : Form
    {
        public Admin_Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 front = new Form1();
            front.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Functions_Form function = new Admin_Functions_Form();
            function.Show();
        }
    }
}
