
using System;
namespace oopUni

{
    public enum Gender
    {
        Male,
        Female
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            double IdealWeight(short height , short age ,Gender gender)
            {
                if (gender == Gender.Male)
                {
                    return (height - 100 + (double)age / 10) * 0.9;
                }
                else
                {
                    return (height - 100 + (double)age / 10) * 0.8;
                }
            }

            Console.WriteLine(IdealWeight(187, 19, Gender.Male));
            Console.WriteLine(IdealWeight(187, 19, Gender.Female));
        }
    }
}