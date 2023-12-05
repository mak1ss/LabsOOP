using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_3_
{

    internal class PremitiveCalculator
    {
        private Dictionary<char, PerformCalculation> strategies;

        private delegate int PerformCalculation(int firstOperand, int secondOperand);

        private PerformCalculation currentStrategy;

        public PremitiveCalculator()
        {
            strategies = new Dictionary<char, PerformCalculation>
            {
                { '+', Add },
                { '-', Subtract },
                { '*', Multiply},
                { '/', Divide}
            };
            currentStrategy = Add;
        }
        public void ChangeStrategy(char @operator)
        {
            if (!strategies.ContainsKey(@operator))
            {
                throw new InvalidOperationException($"Unknown strategy: \"{@operator}\"");
            }
            currentStrategy = strategies[@operator];
        }

        public int? Calculate(int firstOperand, int secondOperand)
        {
            return currentStrategy?.Invoke(firstOperand, secondOperand);
        }

        private int Add(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }

        private int Subtract(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }

        private int Multiply(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }

        private int Divide(int firstOperand, int secondOperand)
        {
            if (secondOperand == 0)
            {
                throw new DivideByZeroException("Divide by 0. Second operand should't be zero");
            }
            return firstOperand / secondOperand;
        }
    }
}
