using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalc.MathOperations
{
    public class AdditionOperation : IMathOperation
    {
        public char Sign => '+';
        public double DoMath(double arg1, double arg2)
        {
            return arg1 + arg2;
        }
    }
}
