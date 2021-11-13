using System;

class GFG
{
    static int findSum(int n)
    {
        int sum = 0;
        for (int x = 1; x <= n; x++)
            sum = sum + x;
        return sum;
    }
    public static void Main()
    {
        int n;
        Console.Write("enter the number \n");
        n = Convert.ToInt32(Console.ReadLine()+"\n");
        Console.Write("\n"+findSum(n)+"\n");
    }
}