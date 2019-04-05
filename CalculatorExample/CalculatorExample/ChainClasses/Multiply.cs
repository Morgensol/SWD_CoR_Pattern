using System;

namespace CalculatorExample
{
    public class Multiply:Chain
    {
        public Multiply(Chain next)
        {
            this.NextInChain = next;
        }
        public override void Calculate(Numbers num)
        {
            if (num.CalcWanted == "multiply")
            {
                Console.WriteLine(num.Number1 + "*" + num.Number2 + "=" + num.Number1*num.Number2);
            }
            else if (num.CalcWanted != null)
            {
                this.NextInChain.Calculate(num);
            }
        }
    }
}