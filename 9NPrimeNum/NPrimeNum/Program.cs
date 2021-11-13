using System;

namespace FirstNPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of n \n");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int noOfPrimeCount = 0, count, num = 2;
            while (noOfPrimeCount < n)
            {
                count = 0;
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                    if (count >= 2)
                    {
                        break;
                    }
                }
                if (count < 2)
                {
                    noOfPrimeCount++;
                    Console.WriteLine(num);
                }
                num++;
            }
        }
    }
}

