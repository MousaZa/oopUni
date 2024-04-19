using System;

namespace oopUni
{

    internal class Operation
    {
        public int Num1 { set; get; }
        public int Num2 { set; get; }
        public char OperationSign { set; get; }

        public Operation()
        {
            Num1 = 0;
            Num2 = 0;
            OperationSign = '+';
        }

        public Operation(int num1 , int num2 , char operationSign)
        {
            Num1 = num1;
            Num2 = num2;
            OperationSign = operationSign;
        }

        public void DoOperation()
        {
            double result = 0;
            switch (OperationSign)
            {
               case '+':
                   result = Num1 + Num2;
                   Console.WriteLine(Num1 +" + "+Num2+" = "+result);
                   break;
               case '-':
                   result = Num1 - Num2;
                   Console.WriteLine(Num1 +" - "+Num2+" = "+result);
                   break;
               case '*':
                   result = Num1 * Num2;
                   Console.WriteLine(Num1 +" * "+Num2+" = "+result);
                   break;
               case '/':
                   try
                   {
                       result = (double)Num1 / Num2;
                       Console.WriteLine(Num1 + " / " + Num2 + " = " + result);
                   }
                   catch (DivideByZeroException x)
                   {
                       Console.WriteLine("Second Number cannot be a 0 !");
                   }
                   break;
               default:
                   Console.WriteLine("Error..");
                   break;
            }
        }
        
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Operation op1 = new Operation(5,2,'/');
            op1.DoOperation();
        }
    }
}