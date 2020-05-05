using System;
using System.Collections.Generic;
using System.Text;

namespace RepLab_2
{
    class NewData
    {
        public int calc(int a, int b, char c)
        {
            switch (c)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                default:
                    return 110011;
            }
        }
        public string newOper(char c)
        {
            switch (c)
            {
                case '!':
                    return "factorial";
                case '^':
                    return "stepen";
                case 's':
                    return "square root";
                default:
                    return "Duno";


            }
        }
        public string textOper(int a, int b, char c)
        {
            Console.WriteLine(a + " " + newOper(c) + " " + b + calc(a, b, c));
        }

    }
}