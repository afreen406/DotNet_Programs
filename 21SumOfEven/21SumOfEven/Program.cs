﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21SumOfEven
{
    class Program
    {
        static void Main() {
      int size;
      int oddSum = 0, evenSum = 0;
      
      Console.WriteLine("Enter the size of the array:");
      size = Convert.ToInt32(Console.ReadLine());
      
      int[] arr = new int[size];
      
      Console.WriteLine("Enter the array values:");
      for(int i = 0; i< size; i++){
        arr[i] = Convert.ToInt32(Console.ReadLine());
      }
      
      for(int i = 0; i< size; i++){
        if(arr[i] % 2 == 0){
            evenSum += arr[i];
        }
      }
      
      Console.WriteLine("Even Sum = {0}:",evenSum);
  }
}
    }
