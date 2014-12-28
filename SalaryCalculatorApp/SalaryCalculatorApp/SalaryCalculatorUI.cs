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
    public partial class SalaryCalculatorUI : Form
    {
        Salary aSalary = new Salary();
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            aSalary.name = nameTextBox.Text;
            aSalary.basicAmountInput = Convert.ToInt32(basicAmountTextBox.Text);
            aSalary.houseRentInput = Convert.ToInt32(rentTextBox.Text);
            aSalary.medicalAllowanceInput = Convert.ToInt32(medicalAllowanceeTextBox.Text);

            aSalary.GetHouseRent();
            aSalary.GetMedicalAllowance();
            aSalary.GetSalary();

            string salary = aSalary.ShowSalary();
            MessageBox.Show(Convert.ToString(salary));
        }
    }
}
