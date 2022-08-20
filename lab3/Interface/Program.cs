using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleInherit
{
    interface Iadd
    {
        int add(int a, int b);  
    }
    interface Isub
    {
        int sub(int x, int y);
    }
    interface Imul
    {
        int mul(int r, int s);
    }
    interface Idiv
    {
        int div(int c, int d);
    }

    class Calc : Iadd, Isub, Imul, Idiv
    {
        public int result1;
        public int add ( int a, int b)
        {
            return result1 = a + b;
        }
        public int result2;
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }
        public int result3;
        public int mul(int r, int s)
        {
            return result3 = r * s;
        }
        public int result4;
        public int div(int c, int d)
        {
            return result4 = c / d;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Calc c = new Calc();
                c.add(1, 2);
                c.sub(2, 1);
                c.mul(2, 6);
                c.div(9, 3);
                Console.WriteLine("Multiple Inheritance using interface");
                Console.WriteLine("Addition: " + c.result1);
                Console.WriteLine("Subtraction: " + c.result2);
                Console.WriteLine("Multiply: " + c.result3);
                Console.WriteLine("Division: " + c.result4);
                Console.ReadKey();
            }
        }
    }
}