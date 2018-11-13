using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {//Assigning local variables
            try
            {
                int num1, num2, sum;
                num1 = Convert.ToInt32(txtFNum.Text);
                num2 = Convert.ToInt32(txtSNum.Text);
                sum = num1 + num2;
                lblResult.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect values");
            }
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, sum;
                num1 = Convert.ToInt32(txtFNum.Text);
                num2 = Convert.ToInt32(txtSNum.Text);
                sum = num1 - num2;
                lblResult.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect values");
            }
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, sum;
                num1 = Convert.ToInt32(txtFNum.Text);
                num2 = Convert.ToInt32(txtSNum.Text);
                sum = num1 * num2;
                lblResult.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect values");
            }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2, sum;
                num1 = Convert.ToDouble(txtFNum.Text);
                num2 = Convert.ToDouble(txtSNum.Text);
                sum = num1 / num2;
                lblResult.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect values");
            }
        }

        private void lnkGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
            lnkGoogle.LinkVisited = true;
        }
    }
}
