
using System;
namespace oopUni

{
    class MyFirstClass
    {

        private int mAge = 0;
        public int age
        {
            set { if(value > 0 ) mAge = value; }
            get { return mAge; }
            
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            MyFirstClass myFirstClass = new MyFirstClass();
            myFirstClass.age = 20;
            Console.WriteLine(myFirstClass.age);
        }
    }
}