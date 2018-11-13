namespace Calculator
{
    partial class Calculator
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
            this.lblFNum = new System.Windows.Forms.Label();
            this.lblSNum = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.txtFNum = new System.Windows.Forms.TextBox();
            this.txtSNum = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lnkGoogle = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblFNum
            // 
            this.lblFNum.AutoSize = true;
            this.lblFNum.Location = new System.Drawing.Point(18, 24);
            this.lblFNum.Name = "lblFNum";
            this.lblFNum.Size = new System.Drawing.Size(69, 13);
            this.lblFNum.TabIndex = 0;
            this.lblFNum.Text = "First Number:";
            // 
            // lblSNum
            // 
            this.lblSNum.AutoSize = true;
            this.lblSNum.Location = new System.Drawing.Point(18, 50);
            this.lblSNum.Name = "lblSNum";
            this.lblSNum.Size = new System.Drawing.Size(87, 13);
            this.lblSNum.TabIndex = 1;
            this.lblSNum.Text = "Second Number:";
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(72, 77);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(45, 23);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "Sub";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // txtFNum
            // 
            this.txtFNum.Location = new System.Drawing.Point(111, 21);
            this.txtFNum.Name = "txtFNum";
            this.txtFNum.Size = new System.Drawing.Size(108, 20);
            this.txtFNum.TabIndex = 1;
            // 
            // txtSNum
            // 
            this.txtSNum.Location = new System.Drawing.Point(111, 47);
            this.txtSNum.Name = "txtSNum";
            this.txtSNum.Size = new System.Drawing.Size(108, 20);
            this.txtSNum.TabIndex = 2;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(18, 112);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(45, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output: ";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(70, 112);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(122, 24);
            this.lblResult.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(123, 77);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(45, 23);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "Mult";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(174, 77);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(45, 23);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "Div";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(21, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;

            // 
            // lnkGoogle
            // 
            this.lnkGoogle.AutoSize = true;
            this.lnkGoogle.Location = new System.Drawing.Point(18, 187);
            this.lnkGoogle.Name = "lnkGoogle";
            this.lnkGoogle.Size = new System.Drawing.Size(64, 13);
            this.lnkGoogle.TabIndex = 8;
            this.lnkGoogle.TabStop = true;
            this.lnkGoogle.Text = "Google.com";
            this.lnkGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoogle_LinkClicked);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 227);
            this.Controls.Add(this.lnkGoogle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtSNum);
            this.Controls.Add(this.txtFNum);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.lblSNum);
            this.Controls.Add(this.lblFNum);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFNum;
        private System.Windows.Forms.Label lblSNum;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox txtFNum;
        private System.Windows.Forms.TextBox txtSNum;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel lnkGoogle;
    }
}

