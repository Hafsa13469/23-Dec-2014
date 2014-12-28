﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWithOOPApp
{
    public partial class CalculatorUI : Form
    {
        Calculator aCalculator = new Calculator();
        
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
            inputString();
          
            int output = aCalculator.add();
            resultTextBox.Text = Convert.ToString(output);
        }

        public void inputString()
        {
            aCalculator.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            aCalculator.lastNumber = Convert.ToInt32(secondNumberTextBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            inputString();
            int output = aCalculator.subtract();
            resultTextBox.Text = Convert.ToString(output);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            inputString();
            int output = aCalculator.multiply();
            resultTextBox.Text = output.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            inputString();
            int output = aCalculator.divide();
            resultTextBox.Text = output.ToString();
        }
    }
}
