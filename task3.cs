using System;
using System.Windows.Forms;

namespace week4_class_task
{
    public partial class task3 : Form
    {
        public task3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int subject1 = Convert.ToInt32(txtSubject1.Text);
            int subject2 = Convert.ToInt32(txtSubject2.Text);
            int subject3 = Convert.ToInt32(txtSubject3.Text);

            int total = subject1 + subject2 + subject3;

            if (subject1 >= 40 && subject2 >= 40 && subject3 >= 40)
            {
                lblResult.Text = "Total = " + total + "\n\nResult = Pass";
            }
            else
            {
                lblResult.Text = "Total = " + total + "\n\nResult = Fail";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
        }
    }
}