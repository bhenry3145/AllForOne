using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.Services
{
    public class AddingTwoNumbersServices
    {
        public string sum = "";
        public bool runs;
        public int convertedNum1;
        public int convertedNum2;
        public string AddNumbers(string num1, string num2)
        {
            runs = (int.TryParse(num1, out convertedNum1) && int.TryParse(num2, out convertedNum2));
            if (runs == false)
            {
                sum = "Please enter 2 numbers";
            }
            else
            {
                sum = "The sum of " + num1 + " and " + num2 + " is equal to " + (convertedNum1 + convertedNum2).ToString();
            }
            return sum;
        }
    }
}