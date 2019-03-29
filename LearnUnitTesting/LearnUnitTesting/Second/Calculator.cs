using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnUnitTesting.Second
{
    public class Calculator : ICalculator
    {
        private IMathLibrary _mathLibrary;
        public Calculator(IMathLibrary mathLibrary)
        {
            _mathLibrary=mathLibrary;
        }
        public double CalculatorSum(double x, double y)
        {
            return _mathLibrary.MathLibraySum(x,y);
        }
    }
}
