
using System;
namespace oopUni

{
    class MyFirstClass
    {

        private int mData;
        public int data
        {
            set { mData = value; }
            get { return mData; }
            
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            MyFirstClass myFirstClass = new MyFirstClass();
            myFirstClass.data = 10;
            Console.WriteLine(myFirstClass.data);
        }
    }
}