
using System;
namespace oopUni

{
    class BaseClass
    {
        public int bNumber { set; get; } = 13 ;
        public BaseClass()
        {
        }

        public BaseClass(int number)
        {
           if(number > 0) bNumber = number;
           else Console.WriteLine("Number should be greater than 0");
        }
        public void printNumber()
        {
            Console.WriteLine("Your Number is : " + bNumber);
        }
        private bool isPrime()
        {
            if (bNumber == 1) return false;
            if (bNumber == 2) return true;
            for (int i = 2; i < bNumber; i++)
            {
                if (bNumber % i == 0) return false;
            }
            return true;
        }

        public void printIsPrime()
        {
            Console.WriteLine( isPrime() ? "Your Number is Prime" : "Your Number is not Prime");
        }
    }
    class DerivedClass : BaseClass
    {
        
        public int dNumber = 20 ;
        new public void PrintNumber()
        {
            Console.WriteLine(dNumber + base.bNumber);
        }
    }

    internal class Program
    { 
        public static void Main(string[] args){
            BaseClass myFirstClass = new BaseClass();
            Console.WriteLine(myFirstClass.bNumber);
            myFirstClass.printIsPrime();
        }
    }
}