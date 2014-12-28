using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithOOPApp
{
    class Calculator
    {
        public int firstNumber;
        public int lastNumber;
        public int result;

        public int add()
        {
          return  result = firstNumber + lastNumber;
        }

        public int subtract()
        {
            return result = firstNumber - lastNumber;
        }

        public int multiply()
        {
            return result = firstNumber*lastNumber;
        }

        public int divide()
        {
            return result = firstNumber/lastNumber;
        }
    }
}
