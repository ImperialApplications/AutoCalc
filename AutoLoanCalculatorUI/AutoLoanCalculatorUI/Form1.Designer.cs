namespace AutoLoanCalculatorUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtBoxSalePrice = new System.Windows.Forms.TextBox();
            this.txtBoxSalesTax = new System.Windows.Forms.TextBox();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.txtBoxTitleFee = new System.Windows.Forms.TextBox();
            this.lblTitleFee = new System.Windows.Forms.Label();
            this.txtBoxTrade = new System.Windows.Forms.TextBox();
            this.lblTrade = new System.Windows.Forms.Label();
            this.txtBoxOther = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.txtBoxRebate = new System.Windows.Forms.TextBox();
            this.lblRebate = new System.Windows.Forms.Label();
            this.txtBoxDown = new System.Windows.Forms.TextBox();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtBoxInterest = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSched = new System.Windows.Forms.Label();
            this.txtBoxExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.txtSched = new System.Windows.Forms.RichTextBox();
            this.btnSched = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboLength = new System.Windows.Forms.ComboBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(13, 14);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(66, 17);
            this.lblSalePrice.TabIndex = 0;
            this.lblSalePrice.Text = "Car Price";
            this.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxSalePrice
            // 
            this.txtBoxSalePrice.Location = new System.Drawing.Point(85, 14);
            this.txtBoxSalePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSalePrice.Name = "txtBoxSalePrice";
            this.txtBoxSalePrice.Size = new System.Drawing.Size(117, 22);
            this.txtBoxSalePrice.TabIndex = 1;
            this.txtBoxSalePrice.Text = "0";
            this.txtBoxSalePrice.TextChanged += new System.EventHandler(this.txtBoxSalePrice_TextChanged);
            // 
            // txtBoxSalesTax
            // 
            this.txtBoxSalesTax.Location = new System.Drawing.Point(85, 41);
            this.txtBoxSalesTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSalesTax.Name = "txtBoxSalesTax";
            this.txtBoxSalesTax.Size = new System.Drawing.Size(117, 22);
            this.txtBoxSalesTax.TabIndex = 2;
            this.txtBoxSalesTax.Text = "0";
            this.txtBoxSalesTax.TextChanged += new System.EventHandler(this.txtBoxSalesTax_TextChanged);
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(13, 41);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(70, 17);
            this.lblSalesTax.TabIndex = 2;
            this.lblSalesTax.Text = "Sales Tax";
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxTitleFee
            // 
            this.txtBoxTitleFee.Location = new System.Drawing.Point(85, 69);
            this.txtBoxTitleFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTitleFee.Name = "txtBoxTitleFee";
            this.txtBoxTitleFee.Size = new System.Drawing.Size(117, 22);
            this.txtBoxTitleFee.TabIndex = 3;
            this.txtBoxTitleFee.Text = "0";
            this.txtBoxTitleFee.TextChanged += new System.EventHandler(this.txtBoxTitleFee_TextChanged);
            // 
            // lblTitleFee
            // 
            this.lblTitleFee.AutoSize = true;
            this.lblTitleFee.Location = new System.Drawing.Point(13, 69);
            this.lblTitleFee.Name = "lblTitleFee";
            this.lblTitleFee.Size = new System.Drawing.Size(63, 17);
            this.lblTitleFee.TabIndex = 4;
            this.lblTitleFee.Text = "Title Fee";
            this.lblTitleFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxTrade
            // 
            this.txtBoxTrade.Location = new System.Drawing.Point(121, 97);
            this.txtBoxTrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTrade.Name = "txtBoxTrade";
            this.txtBoxTrade.Size = new System.Drawing.Size(81, 22);
            this.txtBoxTrade.TabIndex = 4;
            this.txtBoxTrade.Text = "0";
            this.txtBoxTrade.TextChanged += new System.EventHandler(this.txtBoxTrade_TextChanged);
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Location = new System.Drawing.Point(13, 97);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(102, 17);
            this.lblTrade.TabIndex = 6;
            this.lblTrade.Text = "Trade-in Value";
            this.lblTrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxOther
            // 
            this.txtBoxOther.Location = new System.Drawing.Point(99, 123);
            this.txtBoxOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxOther.Name = "txtBoxOther";
            this.txtBoxOther.Size = new System.Drawing.Size(104, 22);
            this.txtBoxOther.TabIndex = 5;
            this.txtBoxOther.Text = "0";
            this.txtBoxOther.TextChanged += new System.EventHandler(this.txtBoxOther_TextChanged);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(13, 123);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(79, 17);
            this.lblOther.TabIndex = 8;
            this.lblOther.Text = "Other Fees";
            this.lblOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxRebate
            // 
            this.txtBoxRebate.Location = new System.Drawing.Point(85, 155);
            this.txtBoxRebate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxRebate.Name = "txtBoxRebate";
            this.txtBoxRebate.Size = new System.Drawing.Size(117, 22);
            this.txtBoxRebate.TabIndex = 6;
            this.txtBoxRebate.Text = "0";
            this.txtBoxRebate.TextChanged += new System.EventHandler(this.txtBoxRebate_TextChanged);
            // 
            // lblRebate
            // 
            this.lblRebate.AutoSize = true;
            this.lblRebate.Location = new System.Drawing.Point(13, 155);
            this.lblRebate.Name = "lblRebate";
            this.lblRebate.Size = new System.Drawing.Size(54, 17);
            this.lblRebate.TabIndex = 10;
            this.lblRebate.Text = "Rebate";
            this.lblRebate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxDown
            // 
            this.txtBoxDown.Location = new System.Drawing.Point(121, 188);
            this.txtBoxDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDown.Name = "txtBoxDown";
            this.txtBoxDown.Size = new System.Drawing.Size(81, 22);
            this.txtBoxDown.TabIndex = 7;
            this.txtBoxDown.Text = "0";
            this.txtBoxDown.TextChanged += new System.EventHandler(this.txtBoxDown_TextChanged);
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Location = new System.Drawing.Point(13, 188);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(102, 17);
            this.lblDown.TabIndex = 12;
            this.lblDown.Text = "Down Payment";
            this.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(13, 222);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(88, 17);
            this.lblLength.TabIndex = 14;
            this.lblLength.Text = "Loan Length";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 318);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(89, 23);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtBoxInterest
            // 
            this.txtBoxInterest.Location = new System.Drawing.Point(107, 254);
            this.txtBoxInterest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxInterest.Name = "txtBoxInterest";
            this.txtBoxInterest.Size = new System.Drawing.Size(96, 22);
            this.txtBoxInterest.TabIndex = 9;
            this.txtBoxInterest.Text = "0";
            this.txtBoxInterest.TextChanged += new System.EventHandler(this.txtBoxInterest_TextChanged);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(13, 254);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(89, 17);
            this.lblInterest.TabIndex = 17;
            this.lblInterest.Text = "Interest Rate";
            this.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(452, 10);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(104, 20);
            this.lblDetails.TabIndex = 19;
            this.lblDetails.Text = "Loan Details";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(556, 46);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(0, 18);
            this.lblPrincipal.TabIndex = 20;
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthly.Location = new System.Drawing.Point(607, 73);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(0, 18);
            this.lblMonthly.TabIndex = 21;
            this.lblMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Monthly Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Principal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSched
            // 
            this.lblSched.AutoSize = true;
            this.lblSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSched.Location = new System.Drawing.Point(244, 370);
            this.lblSched.Name = "lblSched";
            this.lblSched.Size = new System.Drawing.Size(282, 25);
            this.lblSched.TabIndex = 29;
            this.lblSched.Text = "Monthly Amortization Schedule";
            this.lblSched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSched.Visible = false;
            // 
            // txtBoxExtra
            // 
            this.txtBoxExtra.Location = new System.Drawing.Point(125, 281);
            this.txtBoxExtra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxExtra.Name = "txtBoxExtra";
            this.txtBoxExtra.Size = new System.Drawing.Size(77, 22);
            this.txtBoxExtra.TabIndex = 10;
            this.txtBoxExtra.Text = "0";
            this.txtBoxExtra.TextChanged += new System.EventHandler(this.txtBoxExtra_TextChanged);
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(13, 281);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(106, 17);
            this.lblExtra.TabIndex = 39;
            this.lblExtra.Text = "Extra Payments";
            this.lblExtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSched
            // 
            this.txtSched.Location = new System.Drawing.Point(0, 398);
            this.txtSched.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSched.Name = "txtSched";
            this.txtSched.ReadOnly = true;
            this.txtSched.Size = new System.Drawing.Size(769, 121);
            this.txtSched.TabIndex = 40;
            this.txtSched.Text = "";
            this.txtSched.Visible = false;
            // 
            // btnSched
            // 
            this.btnSched.Location = new System.Drawing.Point(637, 295);
            this.btnSched.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSched.Name = "btnSched";
            this.btnSched.Size = new System.Drawing.Size(133, 66);
            this.btnSched.TabIndex = 12;
            this.btnSched.Text = "Payment Schedule";
            this.btnSched.UseVisualStyleBackColor = true;
            this.btnSched.Click += new System.EventHandler(this.btnSched_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(437, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(238, 100);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // comboLength
            // 
            this.comboLength.FormattingEnabled = true;
            this.comboLength.Items.AddRange(new object[] {
            "12",
            "24",
            "36",
            "48",
            "60",
            "72",
            "84"});
            this.comboLength.Location = new System.Drawing.Point(109, 222);
            this.comboLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboLength.Name = "comboLength";
            this.comboLength.Size = new System.Drawing.Size(48, 24);
            this.comboLength.TabIndex = 8;
            this.comboLength.Text = "12";
            this.comboLength.SelectedIndexChanged += new System.EventHandler(this.comboLength_SelectedIndexChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(715, 10);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 17);
            this.lblVersion.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(781, 530);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.comboLength);
            this.Controls.Add(this.btnSched);
            this.Controls.Add(this.txtSched);
            this.Controls.Add(this.txtBoxExtra);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lblSched);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMonthly);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtBoxInterest);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtBoxDown);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.txtBoxRebate);
            this.Controls.Add(this.lblRebate);
            this.Controls.Add(this.txtBoxOther);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.txtBoxTrade);
            this.Controls.Add(this.lblTrade);
            this.Controls.Add(this.txtBoxTitleFee);
            this.Controls.Add(this.lblTitleFee);
            this.Controls.Add(this.txtBoxSalesTax);
            this.Controls.Add(this.lblSalesTax);
            this.Controls.Add(this.txtBoxSalePrice);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Loan Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSalePrice;
        public System.Windows.Forms.TextBox txtBoxSalePrice;
        public System.Windows.Forms.TextBox txtBoxSalesTax;
        public System.Windows.Forms.Label lblSalesTax;
        public System.Windows.Forms.TextBox txtBoxTitleFee;
        public System.Windows.Forms.Label lblTitleFee;
        public System.Windows.Forms.TextBox txtBoxTrade;
        public System.Windows.Forms.Label lblTrade;
        public System.Windows.Forms.TextBox txtBoxOther;
        public System.Windows.Forms.Label lblOther;
        public System.Windows.Forms.TextBox txtBoxRebate;
        public System.Windows.Forms.Label lblRebate;
        public System.Windows.Forms.TextBox txtBoxDown;
        public System.Windows.Forms.Label lblDown;
        public System.Windows.Forms.Label lblLength;
        public System.Windows.Forms.Button btnCalc;
        public System.Windows.Forms.TextBox txtBoxInterest;
        public System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSched;
        public System.Windows.Forms.TextBox txtBoxExtra;
        public System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.RichTextBox txtSched;
        public System.Windows.Forms.Button btnSched;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboLength;
        private System.Windows.Forms.Label lblVersion;
    }
}

