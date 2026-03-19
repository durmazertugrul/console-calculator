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
        public double SecondNumber {  get; set; }
        public double Result {  get; set; }

        public override string ToString()
        {
            return $"{FirstNumber}{Operation}{SecondNumber} = {Result}";
        }


    }
}
