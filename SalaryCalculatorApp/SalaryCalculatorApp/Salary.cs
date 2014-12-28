using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Salary
    {
        public string name;
        public int basicAmountInput;
        public int houseRentInput;
        public int medicalAllowanceInput;

        public int GetHouseRent()
        {
            return basicAmountInput*houseRentInput/100 ;
        }

        public int GetMedicalAllowance()
        {
            return basicAmountInput*medicalAllowanceInput/100;
        }

        public int GetSalary()
        {
            return basicAmountInput + GetHouseRent() + GetMedicalAllowance();
        }

        public string ShowSalary()
        {
            return name + " your Salary is : " + GetSalary();
        }

    }
}
