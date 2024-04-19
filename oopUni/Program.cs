using System;

namespace oopUni
{
    interface IEmployee
    {
        int Id { set; get; }
        string Name { set; get; }

        void PrintId();
        void PrintName();
        
    }

    class Sales : IEmployee
    {

        public Sales(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { set; get; }
        public string Name { set; get; }

        public void PrintId()
        {
            Console.WriteLine(Id);
        }

        public void PrintName()
        {
            Console.WriteLine(Name);
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