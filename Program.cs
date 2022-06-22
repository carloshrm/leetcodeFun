using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();

            var board = new char[][]
            {
                     new char[] { '5', '3', '.', '.', '7', '.', '.','.', '.'}
                    ,new char[] { '6', '.', '3', '1', '9', '5', '.','.', '.'}
                    ,new char[] { '.', '9', '8', '.', '.', '.', '.','6', '.'}
                    ,new char[] { '8', '.', '.', '.', '6', '.', '.','.', '3'}
                    ,new char[] { '4', '.', '.', '8', '.', '3', '.','.', '1'}
                    ,new char[] { '7', '.', '.', '.', '2', '.', '.','.', '6'}
                    ,new char[] { '.', '6', '.', '.', '.', '.', '2','8', '.'}
                    ,new char[] { '.', '.', '.', '4', '1', '9', '.','.', '5'}
                    ,new char[] { '.', '.', '.', '.', '8', '.', '.','7', '9'}
            };

            var testCase = File.ReadAllText(@"3sum.txt").Split(',')
            .Select(x => 
                {
                    int.TryParse(x, out int y);
                    return y;
                }).ToArray();

            var s = new Stopwatch();
            s.Start();
            var test = sln.ThreeSum(testCase);
            s.Stop();
            Console.WriteLine(s.Elapsed);
        }
    }
}
