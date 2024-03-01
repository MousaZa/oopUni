
using System;
namespace oopUni

{
    class MyFirstClass
    {
        // todo public int value {init; get;} = 0 ;
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
            // todo MyFirstClass myFirstClass1 = new MyFirstClass(){value = 10} ;
            // todo myFirstClass1.value = 20; // error
            MyFirstClass myFirstClass = new MyFirstClass();
            myFirstClass.age = 20;
            Console.WriteLine(myFirstClass.age);
        }
    }
}