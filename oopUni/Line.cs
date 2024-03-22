using System;

namespace oopUni
{
    public static class Line
    {
        public static void DrawLine(char character , int number)
        {
            for(int i = 0 ; i < number ; i++)
                Console.Write(character);
            Console.WriteLine();
        }
    }
}