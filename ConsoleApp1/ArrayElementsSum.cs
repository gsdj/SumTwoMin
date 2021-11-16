namespace ConsoleApp1
{
   public class ArrayElementsSum
   {
      public long SumTwoMinElements (int[] arr)
      {
         if (arr != null && arr.Length > 1)
         {
            int a = arr[0];
            int b = arr[0];
            int pos = 0;

            for (int i = 1; i < arr.Length; i++)
            {
               if (arr[i] < a)
               {
                  a = arr[i];
                  pos = i;
               }
               if (arr[i] > b)
               {
                  b = arr[i];
               }
            }

            for (int i = 0; i < arr.Length; i++)
            {
               if (arr[i] >= a && arr[i] < b && i != pos)
               {
                  b = arr[i];
               }
            }

            return (long)a + (long)b;
         }
         return 0;
      }
   }
}
