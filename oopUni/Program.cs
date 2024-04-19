using System;

namespace oopUni
{
    public abstract class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public abstract void PrintId();

        public void PrintName()
        {
            Console.WriteLine(Name);   
        }
        
    }

    class Sales : Employee
    {

        public Sales(int id,string name)
        {
            Id = id;
            Name = name;
        }
        // public int Id { set; get; }
        // public string Name { set; get; }

        public override void PrintId()
        {
            Console.WriteLine(Id);
        }
        
    }
    
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Sales s = new Sales(2 , "Mousa");
            s.PrintName();
            s.PrintId();
        }
    }
}