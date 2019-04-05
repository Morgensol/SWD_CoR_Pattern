using System;

namespace CalculatorExample
{
    public class Subtract: Chain
    {
        public Subtract(Chain next)
        {
            this.NextInChain = next;
        }
        public override void Calculate(Numbers num)
        {
            if (num.CalcWanted == "sub")
            {
                Console.WriteLine(num.Number1 + "-" + num.Number2 + "=" + (num.Number1-num.Number2));
            }
            else if (num.CalcWanted != null)
            {
                this.NextInChain.Calculate(num);
            }
        }

    }
}