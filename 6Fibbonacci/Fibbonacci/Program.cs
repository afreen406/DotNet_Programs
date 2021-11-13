using System;
public class Fibbonacci 
{
    public static void Main(string[] args) 
    {
        int val1 = 0, val2 = 1, val3, i, n;
        Console.Write("Enter the value of n \n");
        n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("First {0} Fibonacci numbers:",n);
        Console.Write(val1+" "+val2+" ");
        
        for(i=2;i<n;++i) 
        {
            val3 = val1 + val2;
            Console.Write(val3 + " ");
            val1 = val2;
            val2 = val3;
        }
   }
}