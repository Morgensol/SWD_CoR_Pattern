namespace CalculatorExample
{
    public class Calculator
    {
        private readonly Chain _calculationChain;

        public Calculator()
        {
            _calculationChain= new Add(
                new Divide(
                new Multiply(
                new Power(
                new Subtract(null)))));
        }

        public void CalculateNumbers(Numbers num)
        {
            _calculationChain.Calculate(num);
        }
    }
}