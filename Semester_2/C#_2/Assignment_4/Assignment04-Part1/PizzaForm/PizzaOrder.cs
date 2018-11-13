using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaForm
{
    public partial class PizzaOrder : Form
    {
        private const double TOPPING_PRICE_VEG = 1.00;
        private const double TOPPING_PRICE_NON = 2.00;
        private const double BASE_PRICE = 10.00;
        private double PRICE = BASE_PRICE;
        public PizzaOrder()
        {
            InitializeComponent();
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnions.Checked)
                PRICE += TOPPING_PRICE_VEG;
            else
                PRICE -= TOPPING_PRICE_VEG;
            lblCost.Text = PRICE.ToString("C");
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
                PRICE += TOPPING_PRICE_VEG;
            else
                PRICE -= TOPPING_PRICE_VEG;
            lblCost.Text = PRICE.ToString("C");
        }

        private void chkPepp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPepp.Checked)
                PRICE += TOPPING_PRICE_NON;
            else
                PRICE -= TOPPING_PRICE_NON;
            lblCost.Text = PRICE.ToString("C");
        }

        private void chkPineapples_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPineapples.Checked)
                PRICE += TOPPING_PRICE_VEG;
            else
                PRICE -= TOPPING_PRICE_VEG;
            lblCost.Text = PRICE.ToString("C");
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushroom.Checked)
                PRICE += TOPPING_PRICE_VEG;
            else
                PRICE -= TOPPING_PRICE_VEG;
            lblCost.Text = PRICE.ToString("C");
        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChicken.Checked)
                PRICE += TOPPING_PRICE_NON;
            else
                PRICE -= TOPPING_PRICE_NON;
            lblCost.Text = PRICE.ToString("C");
        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSausage.Checked)
                PRICE += TOPPING_PRICE_NON;
            else
                PRICE -= TOPPING_PRICE_NON;
            lblCost.Text = PRICE.ToString("C");
        }

        private void chkTomato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomato.Checked)
                PRICE += TOPPING_PRICE_VEG;
            else
                PRICE -= TOPPING_PRICE_VEG;
            lblCost.Text = PRICE.ToString("C");
        }

        private void rdDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDelivery.Checked)
                PRICE += 5;
            else
                PRICE -= 5;
            lblCost.Text = PRICE.ToString("C");
        }

        private void rdExpressDel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdExpressDel.Checked)
                PRICE += 10;
            else
                PRICE -= 10;
            lblCost.Text = PRICE.ToString("C");
        }
    }
}
