using System;
namespace DotNetTutorials
{
    public class CountNoOf1Bits
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter No. :  ");
                int no = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                if (no <= 0)
                    throw new Exception("No. should be greater than 0");
                while (no > 0)
                {
                    if (no % 2 != 0)
                        count++;
                    no /= 2;
                }
                Console.WriteLine("No. of 1's bit is :" + count);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}