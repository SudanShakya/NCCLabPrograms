using System;
using System.Collections.Generic;

namespace GenericQueue
{
    public class Program
    {
        public static void Main()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            //adding duplicate
            queue.Enqueue(3);

            //removing queue
            queue.Dequeue();

            Console.WriteLine("Generic Queue Elements");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}