using System;

class Program
{
   static int FindMax(int[] arr)
   {
       int max = arr[0];
       for (int i = 1; i < arr.Length; i++)
       {
           if(arr[i] > max)
           max = arr[i];
       }
       return max;
   }
   static void Main()
   {
       int[] scores = {45, 67, 89, 23, 90 };
       Console.WriteLine("Max score: " + FindMax(scores));
   }
}