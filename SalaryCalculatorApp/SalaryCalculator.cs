using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class SalaryCalculator
    {
        public string employeeName;
        public double basicAmount;
        public double houseRent;
        public double medicalAllowence;


        public double CalculateSalary()
        {
            return (basicAmount + (basicAmount * houseRent) / 100 + (basicAmount * medicalAllowence) / 100); 
            
         }
    }
}
