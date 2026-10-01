using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace week4_class_task
{
    public partial class task4 : Form
    {
        public task4()
        {
            InitializeComponent();
        }

        private void task4_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                lblResult.Text = "Login Successful";
            }
            else
            {
                lblResult.Text = "Invalid Username or Password";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
