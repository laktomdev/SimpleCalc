using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalc
{
    public interface IMathOperation
    {
        char Sign { get; }
        double DoMath(double arg1, double arg2);
    }



}
