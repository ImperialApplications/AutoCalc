using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AutoLoanCalculatorUI
{
    public partial class Form1 : Form
    {
        static string version = "0.9.0.0";
        double carPrice;
        double principal;
        double salesTax;
        double titleFee;
        double tradeValue;
        double otherFees;
        double rebate;
        double downPayment;
        double months;
        double interestRate;
        double monthlyPayment;
        double extraPayment;
        Chart loanPayment = new Chart();

        public Form1()
        {
            //Write out current version
            File.WriteAllText("appversion.txt", version);
            InitializeComponent();
            lblVersion.Text = "v." + version;
            
        }

        internal void Form1_Load(object sender, EventArgs e)
        {
            Series balance = loanPayment.Series.Add("Balance");
            balance.ChartType = SeriesChartType.Line;
        }

        public void btnCalc_Click(object sender, EventArgs e)
        {
            //loanPayment.Series["Balance"].Points.Clear();
            loanPayment.Size = new Size(175, 115);
            loanPayment.Location = new Point(330, 96);
            this.Controls.Add(loanPayment);
            
            
            DoCalculate();
            loanPayment.Invalidate();
            loanPayment.Update();
        }

        #region Input
        public void txtBoxSalePrice_TextChanged(object sender, EventArgs e)
        {
            carPrice = double.Parse(txtBoxSalePrice.Text);
        }

        public void txtBoxSalesTax_TextChanged(object sender, EventArgs e)
        {
            salesTax = double.Parse(txtBoxSalesTax.Text);
            salesTax = salesTax / 100;
        }

        public void txtBoxTitleFee_TextChanged(object sender, EventArgs e)
        {
            titleFee = double.Parse(txtBoxTitleFee.Text);
        }

        public void txtBoxTrade_TextChanged(object sender, EventArgs e)
        {
            tradeValue = double.Parse(txtBoxTrade.Text);
        }

        public void txtBoxOther_TextChanged(object sender, EventArgs e)
        {
            otherFees = double.Parse(txtBoxOther.Text);
        }

        public void txtBoxRebate_TextChanged(object sender, EventArgs e)
        {
            rebate = double.Parse(txtBoxRebate.Text);
        }

        public void txtBoxDown_TextChanged(object sender, EventArgs e)
        {
            downPayment = double.Parse(txtBoxDown.Text);
        }

        public void txtBoxInterest_TextChanged(object sender, EventArgs e)
        {
            interestRate = double.Parse(txtBoxInterest.Text);
            interestRate = interestRate / 100;
            interestRate = interestRate / 12;
        }

        private void txtBoxExtra_TextChanged(object sender, EventArgs e)
        {
            extraPayment = double.Parse(txtBoxExtra.Text);
        }

        private void comboLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonths = comboLength.SelectedItem.ToString();
            months = double.Parse(selectedMonths);
        }
        #endregion

        void DoCalculate()
        {
            //Calculate Principal Value
            principal = carPrice + (carPrice * salesTax) + titleFee - tradeValue + otherFees - rebate - downPayment;
            lblPrincipal.Text = Convert.ToString(principal);

            //Calculate Monthly Payment
            monthlyPayment = principal * (interestRate * (Math.Pow(1 + interestRate, months)) / (Math.Pow(1 + interestRate, months) - 1));
            double monthlyPaymentR = Math.Round((Double)monthlyPayment, 2);
            lblMonthly.Text = Convert.ToString(monthlyPaymentR);


            double interestPaid;
            double principalPaid;
            double endBalance;
            //Show Amortization Schedule
            txtSched.Text = "Month\tBeginning Balance\tInterest\tPrincipal\tExtra Payment\tEndingBalance\n";
            for (int schedMonths = 1; schedMonths <= months; schedMonths++)
            {
                interestPaid = principal * interestRate;
                principalPaid = monthlyPaymentR - interestPaid;
                endBalance = (principal + (principal * interestRate)) - extraPayment - monthlyPayment;
                double principalR = Math.Round((Double)principal, 2);
                double principalPaidR = Math.Round((Double)principalPaid, 2);
                double endBalanceR = Math.Round((Double)endBalance, 2);
                double interestPaidR = Math.Round((Double)interestPaid, 2);
                txtSched.AppendText(Convert.ToString(schedMonths) + "\t" + Convert.ToString(principalR) + "\t" + "\t" + Convert.ToString(interestPaidR) + "\t"
                    + Convert.ToString(principalPaidR) + "\t" + Convert.ToString(extraPayment) + "\t" + "\t" + Convert.ToString(endBalanceR) + "\n");
                principal = endBalance;
                for (int lineMonths = 0; lineMonths <= months; lineMonths += 6)
                {
                    loanPayment.Series["Balance"].Points.AddY(endBalance);
                }

                if (endBalance < 0)
                {
                    goto AfterLoop;
                }
            }


        AfterLoop:
            Console.ReadLine();
        }
        private void btnSched_Click(object sender, EventArgs e)
        {
            lblSched.Visible = !lblSched.Visible;
            txtSched.Visible = !txtSched.Visible;
            txtSched.Dock = DockStyle.Bottom;
        }


    }
}
