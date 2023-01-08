using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConcepts
{
    public class LinearDataStructures
    {
        /// <summary>
        /// Queue Testing for the required methods
        /// </summary>
        public void QueueMethods()
        {
            NewRegionStarted("Queue");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();

            Console.WriteLine("After Dequeue");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek " + queue.Peek());
            var a = queue.ToArray();
            Console.WriteLine("Array " + a[0]);
        }

        public void ArrayMethods()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            NewRegionStarted("Array");
            Console.WriteLine("The first element of an array {0}", arr[0]);
        }

        public void StackMethods()
        {
            NewRegionStarted("Stack");
            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Popping first Element of Stack");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Peek {0}", stack.Peek());

        }

        public void NewRegionStarted(string region)
        {
            Console.WriteLine("------------------------------------{0} Started---------------------------", region);
        }
    }
}
