using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProLab2
//some comments added
{
    class NewCalculations
    {
        public string operations(char c)
        {
            switch (c)
            {
                case '+':
                    return "summ";
                case '-':
                    return "minus";
                case '*':
                    return "multiply";
                case '/':
                    return "div";
                default:
                    return "Have never heard of this operation";
            }
        }
    }
    //some comments added
}