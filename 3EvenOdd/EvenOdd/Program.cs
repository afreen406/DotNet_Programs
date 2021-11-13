using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of n: ");
            int n;
            n= Convert.ToInt32(Console.ReadLine() + "\n");

            Console.WriteLine("Even Numbers :");
            for (int i = 1; i <=n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            for (int i = 1; i <n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}