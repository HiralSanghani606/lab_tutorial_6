
using System;

class p9
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Func<int, int, int> add = (x, y) => x + y;
        Func<int, int, int> multiply = (x, y) => x * y;
        Func<int, int, int> maximum = (x, y) => x > y ? x : y;

        Console.WriteLine("Addition: " + add(a, b));
        Console.WriteLine("Multiplication: " + multiply(a, b));
        Console.WriteLine("Maximum: " + maximum(a, b));

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}
