using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, reversed = 0, remainder, original;
            Console.Write("Enter an integer: ");
            n = Convert.ToInt32(Console.ReadLine());
            original = n;

            while (n != 0)
            {
                remainder = n % 10;
                reversed = reversed * 10 + remainder;
                n /= 10;
            }

            if (original == reversed)
                Console.Write("{0} is a palindrome.", original);
            else
                Console.Write("{0} is not a palindrome.", original);
        }
    }
}
