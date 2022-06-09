using System;
using System.Diagnostics;

namespace ConsoleApp1
{
   class Program
   {
      static void Main(string[] args)
      {
         ArrayElementsMinSum aes = new ArrayElementsMinSum();

         int[] arr = new int[] { 13, -10, 4, 21, 6, 42, 23, 1023, 6, 232, 34, 2135, 6566, 24, 27, 3423, 423, 321, 357, 9, 7, 64, 345, 690 };

         long res = aes.SumTwoMinElements(arr);
         Console.WriteLine(res);

         Console.ReadLine();
      }

   }

}
