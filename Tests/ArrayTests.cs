using ConsoleApp1;
using Xunit;

namespace Tests
{
   public class ArrayTests
   {
      ArrayElementsSum ars = new ArrayElementsSum();
      [Fact]
      public void Test1()
      {
         int[] arr = new int[] { 5, 3, 5, 8, };
         var res = ars.SumTwoMinElements(arr);
         long exp = 8;
         Assert.Equal(exp, res);
      }
      [Fact]
      public void ArrayIsNull()
      {
         int[] arr = null;
         var res = ars.SumTwoMinElements(arr);
         long exp = 0;
         Assert.Equal(exp, res);
      }
      [Fact]
      public void ArrayWithZero()
      {
         int[] arr = new int[4];
         var res = ars.SumTwoMinElements(arr);
         long exp = 0;
         Assert.Equal(exp, res);
      }
      [Fact]
      public void ArrayLengthLess2()
      {
         int[] arr = new int[] { 34 };
         var res = ars.SumTwoMinElements(arr);
         long exp = 0;
         Assert.Equal(exp, res);
      }

      [Fact]
      public void Test2()
      {
         int[] arr = new int[] { 1, -10, 4, -21, 6, 42, 23, -4, 6, 232, 34, 2135, 6566, 24, -2, 3423, 423, 321, 357, 9, 7, -64, 345 };
         var res = ars.SumTwoMinElements(arr);
         long exp = -85;
         Assert.Equal(exp, res);
      }
   }
}
