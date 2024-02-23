
using System;
namespace oopUni

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}