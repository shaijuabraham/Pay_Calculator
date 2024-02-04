using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHourlyRate.Clear();
            txtHoursWorked.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculatePay_Click(object sender, EventArgs e)
        {
            //Calculate the Pay
            int hourlyRate = int.Parse(txtHourlyRate.Text);
            int hrWorked = int.Parse(txtHoursWorked.Text);

            int grossPay = hourlyRate * hrWorked;

            // Calculate state income tax deduction
            decimal stateIncomeTaxRate = 0.035m * grossPay;

            // Calculate federal income tax deduction
            decimal federalIncomeTaxRate = 0.15m * grossPay;

            // Calculate FICA deductions
            decimal socialSecurityRate = 0.062m; 
            decimal medicareRate = 0.029m; 
            decimal socialSecurityDeduction = grossPay * socialSecurityRate;
            decimal medicareDeduction = grossPay * medicareRate;

            // Calculate net pay (pay after tax deductions)
            decimal netPay = grossPay - stateIncomeTaxRate - federalIncomeTaxRate - socialSecurityDeduction - medicareDeduction;

            lblDIsplay.Text = 
                  "Gross Pay: " + grossPay.ToString() 
                + "\n State IncomeTax : " + stateIncomeTaxRate.ToString()
                + "\n Federal IncomeTax : " + federalIncomeTaxRate.ToString()
                + "\n Social Security : " + socialSecurityRate.ToString()
                + "\n Medicare : " + medicareDeduction.ToString()
                + "\nNet Pay : " + netPay.ToString();




        }
    }
}
