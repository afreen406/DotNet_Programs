using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17CharacterCombination
{
    public class Program
    {
        //Function for swapping the characters at position I with character at position j  
        public static String swapString(String a, int i, int j)
        {
            char[] b = a.ToCharArray();
            char ch;
            ch = b[i];
            b[i] = b[j];
            b[j] = ch;
            //Converting characters from array into single string  
            return string.Join("", b);
        }

        public static void Main()
        {
            Console.Write("enter the String: \n");
            String str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine("All the Combination of the string are: ");
            generatePermutation(str, 0, len);

        }

        //Function for generating different permutations of the string  
        public static void generatePermutation(String str, int start, int end)
        {
            //Prints the permutations  
            if (start == end - 1)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i < end; i++)
                {
                    //Swapping the string by fixing a character  
                    str = swapString(str, start, i);
                    //Recursively calling function generatePermutation() for rest of the characters   
                    generatePermutation(str, start + 1, end);
                    //Backtracking and swapping the characters again.  
                    str = swapString(str, start, i);
                }
            }
        }
    }  

}
                     
