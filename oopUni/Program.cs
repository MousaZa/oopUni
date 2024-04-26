using System;
using System.Runtime.Remoting.Contexts;

namespace oopUni
{

    internal class Complex
    {
        private int Real;
        private int Imaginary;
        
        public int real { set => Real = value; get => Real; }
        public int imaginary { set => Imaginary = value; get => Imaginary; }
        
        public Complex(){}

        public Complex(int _real, int _imaginary)
        {
            Real = _real;
            Imaginary = _imaginary;
        }

        public void PrintNumber()
        {
            Console.WriteLine(Real + " + " + Imaginary + "i");
        }

        public static Complex operator +(Complex complex1, Complex complex2)
        {
            Complex result = new Complex();
            result.Real = complex1.Real + complex2.Real;
            result.Imaginary = complex1.Imaginary + complex2.Imaginary;
            return result;
        }
    }
   
    internal class Program
    {
        public static void Main(string[] args)
        {
            Complex number1 = new Complex(3, 4);
            Complex number2 = new Complex(4, 5);
            Complex number3 = number1 + number2;
            number3.PrintNumber(); 
        }
    }
}