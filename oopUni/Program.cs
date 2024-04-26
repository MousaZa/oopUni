using System;

namespace oopUni
{
    internal class Class
    {
        private int Member; // field
        
        public int member  // setter & getter ~ Simpler way ~
        {
            set => Member = value;
            get => Member;
        }

        public void setMember(int _Member) // setter 
        {
            Member = _Member;
        }

        public int getMember() // getter 
        {
            return Member;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
      
            
            
        }
    }
}