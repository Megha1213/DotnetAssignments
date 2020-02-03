using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary to Decimal:");
            BinToDec();  //call BinToDec

            Console.WriteLine("Decimal to Binary:");
            DecToBin();  //call DecToBin

            Console.WriteLine("Decimal to Hex:");
            DecToHex();  //call DecToHex

            Console.WriteLine("Decimal to Octa:");
            DecToOcta();  //call DecToOcta

            Console.Read();
        }
        static void BinToDec()
        {
            int binVal, decVal = 0, baseVal = 1, temp,number;
            Console.Write("Enter Binary number:");
            number=int.Parse(Console.ReadLine());
            binVal = number;
            while (number > 0)
            {
                temp = number % 10;
                decVal = decVal + temp * baseVal;
                number = number / 10;

                baseVal = baseVal * 2;
            }
            Console.Write("Binary Number: " + binVal + " Converted To Decimal Number: " + decVal);
            Console.ReadLine();

        }
        static void DecToBin()
        {
            int decVal, val,number;
            string a = "";
            Console.Write("Enter Decimal Number:");
            decVal = int.Parse(Console.ReadLine());
            number = decVal;
            while(decVal>=1)
            {
                val = decVal / 2;
                a += (decVal % 2).ToString();
                decVal = val;
            }
            string binVal = "";
            for(int i=a.Length-1;i>=0;i--)
            {
                binVal = binVal + a[i];
            }
            Console.Write("Decimal Number: " + number + " Converted To Binary Number: " + binVal);
            Console.ReadLine();
        }
        static void DecToHex()
        {
            char []hexNum = new char[100];
            int i = 0,n;
            Console.Write("Enter Decimal Number:");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                int temp = 0;
                temp = n % 16;
                if(temp<10)
                {
                    hexNum[i] = (char)(temp + 48);
                    i++;
                }
                else
                {
                    hexNum[i] =(char)(temp + 55);
                    i++;
                }
                n=n/16;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(hexNum[j]);
            }
        }
        static void DecToOcta()
        {
            int decVal, temp, i = 1, j;
            int[] octVal = new int[100];
            Console.Write("Enter Decimal Number:");
            temp = int.Parse(Console.ReadLine());
            while(temp!=0)
            {
                octVal[i++] = temp % 8;
                temp = temp / 8;
            }
            for(j=i-1;j>0;j--)
            {
                Console.Write(octVal[j]);
            }
        }
    }
}
