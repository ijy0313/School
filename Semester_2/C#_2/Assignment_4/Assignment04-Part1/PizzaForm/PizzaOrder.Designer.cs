namespace PizzaForm
{
    partial class PizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPizza = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblDining = new System.Windows.Forms.Label();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkPepp = new System.Windows.Forms.CheckBox();
            this.chkPineapples = new System.Windows.Forms.CheckBox();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdDelivery = new System.Windows.Forms.RadioButton();
            this.rdDineIn = new System.Windows.Forms.RadioButton();
            this.rdExpressDel = new System.Windows.Forms.RadioButton();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPizza
            // 
            this.lblPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizza.Location = new System.Drawing.Point(41, 21);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(263, 41);
            this.lblPizza.TabIndex = 0;
            this.lblPizza.Text = "Pizza Order Form";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(12, 71);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(145, 13);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Select Your Toppings +$1.00";
            // 
            // lblDining
            // 
            this.lblDining.AutoSize = true;
            this.lblDining.Location = new System.Drawing.Point(173, 160);
            this.lblDining.Name = "lblDining";
            this.lblDining.Size = new System.Drawing.Size(76, 13);
            this.lblDining.TabIndex = 2;
            this.lblDining.Text = "Dining Options";
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(15, 88);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(59, 17);
            this.chkOnions.TabIndex = 3;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            this.chkOnions.CheckedChanged += new System.EventHandler(this.chkOnions_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(15, 113);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkPepp
            // 
            this.chkPepp.AutoSize = true;
            this.chkPepp.Location = new System.Drawing.Point(15, 136);
            this.chkPepp.Name = "chkPepp";
            this.chkPepp.Size = new System.Drawing.Size(74, 17);
            this.chkPepp.TabIndex = 5;
            this.chkPepp.Text = "Pepperoni";
            this.chkPepp.UseVisualStyleBackColor = true;
            this.chkPepp.CheckedChanged += new System.EventHandler(this.chkPepp_CheckedChanged);
            // 
            // chkPineapples
            // 
            this.chkPineapples.AutoSize = true;
            this.chkPineapples.Location = new System.Drawing.Point(15, 160);
            this.chkPineapples.Name = "chkPineapples";
            this.chkPineapples.Size = new System.Drawing.Size(78, 17);
            this.chkPineapples.TabIndex = 6;
            this.chkPineapples.Text = "Pineapples";
            this.chkPineapples.UseVisualStyleBackColor = true;
            this.chkPineapples.CheckedChanged += new System.EventHandler(this.chkPineapples_CheckedChanged);
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Location = new System.Drawing.Point(176, 182);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(70, 17);
            this.rdTakeOut.TabIndex = 7;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "Take Out";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            // 
            // rdDelivery
            // 
            this.rdDelivery.AutoSize = true;
            this.rdDelivery.Location = new System.Drawing.Point(176, 207);
            this.rdDelivery.Name = "rdDelivery";
            this.rdDelivery.Size = new System.Drawing.Size(99, 17);
            this.rdDelivery.TabIndex = 8;
            this.rdDelivery.TabStop = true;
            this.rdDelivery.Text = "Delivery +$5.00";
            this.rdDelivery.UseVisualStyleBackColor = true;
            this.rdDelivery.CheckedChanged += new System.EventHandler(this.rdDelivery_CheckedChanged);
            // 
            // rdDineIn
            // 
            this.rdDineIn.AutoSize = true;
            this.rdDineIn.Location = new System.Drawing.Point(176, 254);
            this.rdDineIn.Name = "rdDineIn";
            this.rdDineIn.Size = new System.Drawing.Size(59, 17);
            this.rdDineIn.TabIndex = 9;
            this.rdDineIn.TabStop = true;
            this.rdDineIn.Text = "Dine In";
            this.rdDineIn.UseVisualStyleBackColor = true;
            // 
            // rdExpressDel
            // 
            this.rdExpressDel.AutoSize = true;
            this.rdExpressDel.Location = new System.Drawing.Point(176, 230);
            this.rdExpressDel.Name = "rdExpressDel";
            this.rdExpressDel.Size = new System.Drawing.Size(145, 17);
            this.rdExpressDel.TabIndex = 10;
            this.rdExpressDel.TabStop = true;
            this.rdExpressDel.Text = "Express Delivery +$10.00";
            this.rdExpressDel.UseVisualStyleBackColor = true;
            this.rdExpressDel.CheckedChanged += new System.EventHandler(this.rdExpressDel_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(15, 183);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(75, 17);
            this.chkMushroom.TabIndex = 11;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(15, 207);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(65, 17);
            this.chkChicken.TabIndex = 12;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            this.chkChicken.CheckedChanged += new System.EventHandler(this.chkChicken_CheckedChanged);
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(15, 231);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(73, 17);
            this.chkSausage.TabIndex = 13;
            this.chkSausage.Text = "Sausages";
            this.chkSausage.UseVisualStyleBackColor = true;
            this.chkSausage.CheckedChanged += new System.EventHandler(this.chkSausage_CheckedChanged);
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Location = new System.Drawing.Point(15, 254);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(73, 17);
            this.chkTomato.TabIndex = 14;
            this.chkTomato.Text = "Tomatoes";
            this.chkTomato.UseVisualStyleBackColor = true;
            this.chkTomato.CheckedChanged += new System.EventHandler(this.chkTomato_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(86, 289);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total: ";
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(130, 289);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(71, 13);
            this.lblCost.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 322);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkTomato);
            this.Controls.Add(this.chkSausage);
            this.Controls.Add(this.chkChicken);
            this.Controls.Add(this.chkMushroom);
            this.Controls.Add(this.rdExpressDel);
            this.Controls.Add(this.rdDineIn);
            this.Controls.Add(this.rdDelivery);
            this.Controls.Add(this.rdTakeOut);
            this.Controls.Add(this.chkPineapples);
            this.Controls.Add(this.chkPepp);
            this.Controls.Add(this.chkOlives);
            this.Controls.Add(this.chkOnions);
            this.Controls.Add(this.lblDining);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblPizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblDining;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkPepp;
        private System.Windows.Forms.CheckBox chkPineapples;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdDelivery;
        private System.Windows.Forms.RadioButton rdDineIn;
        private System.Windows.Forms.RadioButton rdExpressDel;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCost;
    }
}

