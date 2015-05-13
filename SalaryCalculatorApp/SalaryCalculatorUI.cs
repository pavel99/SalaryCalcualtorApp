using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class CalculatorSalaryUI : Form
    {
        public CalculatorSalaryUI()
        {
            InitializeComponent();
        }
        SalaryCalculator aSalaryCalculator = new SalaryCalculator();
        private void showButton_Click(object sender, EventArgs e)
        {
            aSalaryCalculator.employeeName=nameTextBox.Text;
            aSalaryCalculator.basicAmount = Convert.ToDouble(amountTextBox.Text);
            aSalaryCalculator.houseRent=Convert.ToDouble(rentTextBox.Text);
            aSalaryCalculator.medicalAllowence = Convert.ToDouble(medicalTextBox.Text);

            double salary = (aSalaryCalculator.CalculateSalary());
            MessageBox.Show( aSalaryCalculator.employeeName + " Your total salary Is : " +salary);


            nameTextBox.Clear();
            rentTextBox.Clear();
            amountTextBox.Clear();
            medicalTextBox.Clear();
        }
    }
}
