using System;

namespace leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();
            var result = sln.ShiftGrid(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }, 1);

            Console.WriteLine(result);
        }
    }
}
