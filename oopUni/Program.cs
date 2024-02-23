
using System;
namespace oopUni

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[4] { 0, 1, 2, 3 };
            jagged[1] = new int[2] { 4, 5 };
            jagged[2] = new int[3] { 6, 7, 8 };
            
            // 0 1 2 3
            // 4 5 
            // 6 7 8
        }
    }
}