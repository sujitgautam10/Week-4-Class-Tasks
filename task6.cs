using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace week4_class_task
{
    public partial class task6 : Form
    {
        public task6()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            {
                int secretNumber = 7;
                int guess = Convert.ToInt32(txtGuess.Text);

                if (guess == secretNumber)
                {
                    lblResult.Text = "Correct Guess!";
                }
                else if (guess > secretNumber)
                {
                    lblResult.Text = "Try a smaller number.";
                }
                else
                {
                    lblResult.Text = "Try a larger number.";
                }
            }
        }
    }
}
