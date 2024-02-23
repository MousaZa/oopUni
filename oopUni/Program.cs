
using System;
namespace oopUni

{
    class MyFirstClass
    {
        public MyFirstClass(int value)
        {
            _mValue = value;
        }
        
        int _mValue;
        public void PrintValue()
        {
            Console.WriteLine("the value is " + _mValue);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            MyFirstClass myFirstClass = new MyFirstClass(5);
            myFirstClass.PrintValue();
        }
    }
}