
using System;
namespace oopUni

{
    class BaseClass
    {
        public int bNumber = 10 ;

        
        public void PrintNumber()
        {
            Console.WriteLine(bNumber);
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
            DerivedClass myFirstClass = new DerivedClass();
            Console.WriteLine(myFirstClass.bNumber);
            Console.WriteLine(myFirstClass.dNumber);
        }
    }
}