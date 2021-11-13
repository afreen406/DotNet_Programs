using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCM_GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, gcd, lcm, remainder, numerator, denominator;

            Console.Write("Enter first number\n");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number\n");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 > num2)
            {
                numerator = num1;
                denominator = num2;
            }
            else
            {
                numerator = num2;
                denominator = num1;
            }
            remainder = numerator % denominator;
            while (remainder != 0)
            {
                numerator = denominator;
                denominator = remainder;
                remainder = numerator % denominator;
            }
            gcd = denominator;
            lcm = num1 * num2 / gcd;
           
            Console.Write("LCM of {0} & {1} = {2}\n", num1, num2, lcm);
            Console.Write("GCD of {0} & {1} = {2}\n", num1, num2, gcd);
        }
    }
}
