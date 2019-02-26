using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalc
{
    public class Calculator
    {
        public double Arg1 { get; set; }
        public double Arg2 { get; set; }

        public IMathOperation MathOperation { get; set; }


        public double CalculateResult()
        {
            return MathOperation.DoMath(Arg1, Arg2);
        }

    }

  
}
