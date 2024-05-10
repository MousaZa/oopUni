using System;
using System.Collections ;
namespace oopUni
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ArrayList List = new ArrayList();
            List.Add(5);
            List.Add(1.0f);
            List.Add("Hello");
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            foreach (var var in queue)
            {
                Console.WriteLine(var);
            }
            Console.WriteLine("==============");
            foreach (var var in stack)
            {
                Console.WriteLine(var);
            }
            Console.WriteLine("==============");
            foreach (var var in List)
            {
                Console.WriteLine(var);
            }
        }
    }
}