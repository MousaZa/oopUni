using System;

namespace oopUni
{
    internal class Sentence
    {
        
        private string[] Words; // field

        public string this[int index]
        {
            set
            {
                try
                {
                    Words[index] = value;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range");
                }
            }
            get
            {
                try
                {
                    return Words[index];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range");
                    return "";
                }
            } 
        }

        public Sentence()
        {
            Words = "Today is Friday".Split();
        }

        public Sentence(string sentence)
        {
            Words = sentence.Split();
        }

        public void PrintWordOfIndex(int index)
        {
          Console.WriteLine((index + 1)+ ".Word is: " + this[index]);
        }

        public void PrintWords()
        {
            foreach (var word in Words)
            {
                Console.WriteLine(word);
            }
        }
        
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {

            Sentence sentence = new Sentence("I am BATMAN! :)");
            sentence.PrintWords();
            sentence.PrintWordOfIndex(5);
           
        }
    }
}