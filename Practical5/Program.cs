using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    class Program
    {
        static Boolean isOperator(char x)
        {

            switch (x)
            {
                case '+':
                case '-':
                case '/':
                case '*':
                    return true;
            }
            return false;
        }
        static String postToPre(String post_exp)
        {
            Stack s = new Stack();
            int length = post_exp.Length;
            for (int i = 0; i < length; i++)
            { 
                if (isOperator(post_exp[i]))
                {
                    String op1 = (String)s.Peek();
                    s.Pop();
                    String op2 = (String)s.Peek();
                    s.Pop();
                    String temp = post_exp[i] + op2 + op1;
                    s.Push(temp);
                }
                else
                {
                    s.Push(post_exp[i] + "");
                }
            }
            return (String)s.Peek();
        }

        static void Main(string[] args)
        {
        }
    }
}
