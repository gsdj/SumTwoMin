namespace ConsoleApp1
{
   public class ArrayElementsMinSum
   {
      public long SumTwoMinElements (int[] arr)
      {
         if (arr != null && arr.Length >= 2)
         {
            int min1Id = 0;
            int min2Id = 1;

            if (arr[min2Id] < arr[min1Id])
            {
               int a = min1Id;
               min1Id = min2Id;
               min2Id = a;
            }

            for (int i = 2; i < arr.Length; i++)
            {
               if (arr[i] < arr[min1Id])
               {
                  min2Id = min1Id;
                  min1Id = i;
               }
               else if (arr[i] < arr[min2Id])
               {
                  min2Id = i;
               }
            }

            long result = arr[min1Id] + arr[min2Id];

            return result;
         }
         return 0;
      }
   }
}
