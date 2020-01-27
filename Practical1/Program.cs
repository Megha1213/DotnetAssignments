using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern 1");
            pattern1();  //call pattern1

            Console.WriteLine("Pattern 2");
            pattern2();  //call pattern1

            Console.WriteLine("Pattern 3");
            pattern3();  //call pattern1

            Console.Read();
        }
        //pettern1
        static void pattern1()
        {
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        //pettern2
        static void pattern2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        //pettern3
        static void pattern3()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
