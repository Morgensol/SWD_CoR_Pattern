using System;
namespace CalculatorExample
{
    public class Power: Chain
    {
        public Power(Chain next)
        {
            this.NextInChain = next;
        }
        public override void Calculate(Numbers num)
        {
            if (num.CalcWanted == "pow")
            {
                Console.WriteLine(num.Number1 + "^"+num.Number2+"="+ Math.Pow(num.Number1, num.Number2));
            }
            else if (num.CalcWanted!=null)
            {
                this.NextInChain.Calculate(num);
            }
        }
    }
}