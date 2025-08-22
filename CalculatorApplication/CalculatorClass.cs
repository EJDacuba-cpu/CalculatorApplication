using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T a, T b);
    internal class CalculatorClass
    {
        public Formula<double> info;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2)
        { return num1 - num2; }

        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                info += value;
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
                info -= value;



            }
        }
    }
}
