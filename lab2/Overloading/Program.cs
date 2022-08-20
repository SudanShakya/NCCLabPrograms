using System;

class Rectangle
{
    public static void PrintArea(int x, int y)
    {
        Console.WriteLine(x*y);
    }
    public static void PrintArea(int x)
    {
        Console.WriteLine(x*x);
    }
    public static void PrintArea(int x , double y)
    {
        Console.WriteLine(x*y);
    }
    public static void PrintArea(double x)
    {
        Console.WriteLine(x * x);
    }

    static void Main(string[] args)
    {
        PrintArea(3, 2);
        PrintArea(3, 4.5);
        PrintArea(4);
        PrintArea(3.2);
    }
} 