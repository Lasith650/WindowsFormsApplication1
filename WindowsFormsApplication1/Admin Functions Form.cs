﻿using System;
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
    public partial class Admin_Functions_Form : Form
    {
        public Admin_Functions_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login_Form login = new Admin_Login_Form();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_User_Form user = new Add_New_User_Form();
            user.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remove_User_Form remove = new Remove_User_Form();
            remove.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Supplier_Form supplier = new Add_New_Supplier_Form();
            supplier.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Supplier_Form delete = new Delete_Supplier_Form();
            delete.Show();
        }
    }
}
