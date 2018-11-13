using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise01
{
    public partial class MenuStrip : Form
    {
        public MenuStrip()
        {
            InitializeComponent();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.Font = new Font("Calibri", 10);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.Font = new Font("Calibri", 16);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.Font = new Font("Calibri", 24);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.ForeColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.ForeColor = Color.Green;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "This program is used to choose different colors and fonts.";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(lblOutput.Font, FontStyle.Underline);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(lblOutput.Font, FontStyle.Bold);
        }
    }
}
