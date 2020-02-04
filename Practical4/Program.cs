using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class Program
    {
        public static void Main(string[] args)
        {
            string infix = "a+b*c-d/e*f";
            String postfix = InfixToPostfix(infix);
            Console.WriteLine("Infix :" + infix + " Converted To Postfix : " + postfix);
            Console.ReadLine();
        }
        public static string InfixToPostfix(string expression)
        {
            String result = String.Empty;
            Stack<char> s = new Stack<char>();
            for(int i=0;i<expression.Length;++i)
            {
                char c = expression[i];
                if(Char.IsLetterOrDigit(c))
                {
                    result += c;
                }
                else if(c=='(')
                {
                    s.Push(c);
                }
                else if(c==')')
                {
                    while (s.Count != 0 && s.Peek() != '(')
                        result += s.Pop();
                    if (s.Count != 0 && s.Peek() != '(')
                        return "Invalid";
                    else
                        s.Pop();
                }
                else
                {
                    while(s.Count != 0 && Precision(c)<=Precision(s.Peek()))
                    {
                        result += s.Pop();
                    }
                    s.Push(c);
                }
            }
            while(s.Count!=0)
            {
                result += s.Pop();
            }
            return result; 
        }
        public static int Precision(char ch)
        {
            switch(ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }
    }
}
