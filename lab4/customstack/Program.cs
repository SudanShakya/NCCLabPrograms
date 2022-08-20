using System;
using System.Collections.Generic;

namespace GenericStack
{
    public class Program
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            //adding duplicate
            stack.Push(3);

            //removing element
            stack.Pop();

            Console.WriteLine("Generic Stack Elements");
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        
        }
    }
}