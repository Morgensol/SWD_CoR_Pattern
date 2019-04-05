using System.Data;

namespace CalculatorExample
{
    public class Numbers
    {
        public  string CalcWanted { get;}
        public double Number1 { get;}
        public double Number2 { get;}

        public Numbers(int num1, int num2, string request)
        {
            Number1 = num1;
            Number2 = num2;
            CalcWanted = request;
        }
    }
}