using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumber
{
    class Prime
    {
        static void Main(string[] args)
        {
            int num;      
            Console.Write("Enter the number\n");
            num = Convert.ToInt32(Console.ReadLine());
            int count = 0;       

            for (int i = 2; i < num; i++)  
            {
                if (num % i == 0)
                    count++;
            }
            if (count != 0)           
            {
                Console.Write("{0} is Not a prime number\n",num);
            }
            else
            {
                Console.Write("{0} is Prime number\n",num);
            }
        }
    }
}
