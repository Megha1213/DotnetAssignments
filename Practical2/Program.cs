using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, country;
            do
            {
                Console.WriteLine("who are you?");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name, "^[a-zA-Z]+$"));

            do
            {
                Console.WriteLine("where are you from?");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(country, "^[a-zA-Z]+$"));


            Console.WriteLine("hi," + name + " from " + country);
            Console.ReadLine();
        }
    }
}
