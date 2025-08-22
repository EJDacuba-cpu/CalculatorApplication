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

        //Addition
        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        //subtraction
        public double GetDifference(double num1, double num2)
        { return num1 - num2; }

        //Multiplication
        public double GetProduct(double num1, double num2)
            { return num1 * num2; }

        //Subtraction
        public double Getquotient(double num1, double num2)
            {  if(num2 == 0)// Check kung divide by zero
                throw new DivideByZeroException("Di pwede Yan Lods.");
            return num1 / num2;
            }
        // accessor para makita kapag nag-add o nag-remove ng delegate
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
