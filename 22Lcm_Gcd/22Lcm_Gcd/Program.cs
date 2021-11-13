using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22Lcm_Gcd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, hcf, st;
            Console.Write("Enter Num 1 \n");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Num 2 \n");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Num 3 \n");
            c = Convert.ToInt32(Console.ReadLine());
           

            st = a < b ? (a < c ? a : c) : (b < c ? b : c);

            for (hcf = st; hcf >= 1; hcf--)
            {
                if (a % hcf == 0 && b % hcf == 0 && c % hcf == 0)
                    break;
            }

            Console.Write("The Hcf of three Number is {0}", hcf); 
 
        }
    }
}
