using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18Factors
{
    class Program
    {
        static void PrintFactors(int number)
        {
            int iLoop = 0;
            Console.WriteLine("The all factors of " + number + " are :");

            for (iLoop = 1; iLoop <= number; iLoop++)
            {
                if (number % iLoop == 0)
                {
                    Console.Write(iLoop + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int number = 0;

            Console.Write("Enter an integer number: ");
            number = int.Parse(Console.ReadLine());

            PrintFactors(number);

            Console.WriteLine();
        }
    }
}
