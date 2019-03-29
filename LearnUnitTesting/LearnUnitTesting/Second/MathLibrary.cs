using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnUnitTesting.Second
{
    public  class MathLibrary : IMathLibrary
    {
        public double MathLibraySum(double a, double b)
        {
            return a+b;
        }
    }
}
