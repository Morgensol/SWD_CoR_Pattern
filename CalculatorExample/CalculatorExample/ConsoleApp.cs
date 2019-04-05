using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.CalculateNumbers(new Numbers(3,2,"div"));
            calc.CalculateNumbers(new Numbers(3, 2, "add"));
            calc.CalculateNumbers(new Numbers(3, 2, "pow"));
            calc.CalculateNumbers(new Numbers(3, 2, "multiply"));
            calc.CalculateNumbers(new Numbers(3, 2, "sub"));

        }
    }
}
