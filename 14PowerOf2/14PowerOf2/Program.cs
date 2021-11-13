using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14PowerOf2
{
    class Program
    {
        static void Main(string[] args)
        { 
            int num;
            int tempNum, flag;

            Console.Write("Enter the Number:\n");
            num = Convert.ToInt32(Console.ReadLine());
                      
            tempNum = num;
            flag = 0;
            /*check power of two*/
            while (tempNum != 1)
            {
                if (tempNum % 2 != 0)
                {
                    flag = 1;
                    break;
                }
                tempNum = tempNum / 2;
            }

            if (flag == 0)
                Console.WriteLine("{0} is a number that is the power of 2.", num);
            else
                Console.WriteLine("{0} is not the power of 2.", num);
        }
    }
}
