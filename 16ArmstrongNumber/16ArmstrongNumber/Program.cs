using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, n, qsum, r;
            Console.WriteLine("Armstrong Number from 1 to 500");
            for (num = 1; num <= 500; num++)
            {
                qsum = 0;
                n = num;
                while (n != 0)
                {
                    r = n % 10;
                    qsum = qsum + (r * r * r);
                    n = n / 10;
                }
                if (num == qsum)
                    Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
