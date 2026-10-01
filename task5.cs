using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace week4_class_task
{
    public partial class task5 : Form
    {
        public task5()
        {
            InitializeComponent();
        }

        private void task5_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            {
                int units = Convert.ToInt32(txtUnits.Text);
                int bill;

                if (units <= 100)
                {
                    bill = units * 5;
                }
                else if (units <= 200)
                {
                    bill = (100 * 5) + ((units - 100) * 7);
                }
                else
                {
                    bill = (100 * 5) + (100 * 7) + ((units - 200) * 10);
                }

                lblBill.Text = "Bill Amount = Rs. " + bill;
            }
        }
    }
}
