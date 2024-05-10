using System;
using System.Collections ;
namespace oopUni
{

    class Number // for numbers between 1 - 999
    {
        private int Num;
        private ArrayList Dividers;

        public int num {
            set => Num = value;
            get => Num;
        }

        public Number()
        {
            Random rnd = new Random();
            Num = rnd.Next(1, 999);
        }

        public Number(int _num)
        {
            if (_num >= 1 && _num <= 999)
            {
                Num = _num;
            }
            else
            {
                Console.WriteLine("Number out of range , Number set to a random number");
                Random rnd = new Random();
                Num = rnd.Next(1, 999);
            }
        }

        private void CalculateDividers()
        {
            Dividers = new ArrayList();

            
            for (int i = 2 ; i < Num ; i++)
            {
                if (Num % i == 0)
                {
                    Dividers.Add(i);
                }
            }
        }

        public void PrintDividers()
        {
            CalculateDividers();
            if (Dividers.Count == 0)
            {
                Console.WriteLine(Num+" is a Prime Number");
            }
            else
            {
                Console.WriteLine("The dividers of " + Num + " are :");

                foreach (var var in Dividers)
                {
                    Console.WriteLine(var);
                }
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {

            Number num = new Number(23);
            num.PrintDividers();
            
        }
    }
}
