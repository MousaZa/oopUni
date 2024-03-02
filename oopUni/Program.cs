
using System;
namespace oopUni

{
    class MyFirstClass
    {
        private int mAge = 0;

        public MyFirstClass()
        {
            
        }

        public MyFirstClass(int _age)
        {
            mAge = _age;
        }

        public void setAge(int _age)
        {
            mAge = _age;
        }

        public void printAge()
        {
            Console.WriteLine("your age is " + mAge);
        }
    }

    internal class Program
    {
        public static void Main(string[] args){
            MyFirstClass myFirstClass = new MyFirstClass(10);
            myFirstClass.printAge();
            myFirstClass.setAge(20) ;
            myFirstClass.printAge();
        }
    }
}