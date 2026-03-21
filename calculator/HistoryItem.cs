using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class HistoryItem
    {
        public string Operation {  get; set; }
        public double FirstNumber {  get; set; }
        public double? SecondNumber {  get; set; } // nullable
        public double Result {  get; set; }

        public override string ToString()
        {
            if (Operation == "√") 
            {
               return $"√{FirstNumber} = {Result}"; // To avoid showing a second number in history for single-number operations
            }
            else 
            {
                return $"{FirstNumber}{Operation}{SecondNumber} = {Result}";
            }
                
        }


    }
}
