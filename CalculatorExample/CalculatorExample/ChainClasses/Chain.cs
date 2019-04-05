namespace CalculatorExample
{
    public abstract class Chain
    {
        protected Chain NextInChain;
        public abstract void Calculate(Numbers num);
    }
}