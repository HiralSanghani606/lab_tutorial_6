using System;

public delegate int Calc(int a, int b);

class p3
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }

    static void Main()
    {
        int a = 45, b = 5;

        Calc c;

        c = Add;
        Console.WriteLine("Addition: " + c(a, b));

        c = Subtract;
        Console.WriteLine("Subtraction: " + c(a, b));

        c = Multiply;
        Console.WriteLine("Multiplication: " + c(a, b));

        c = Divide;
        Console.WriteLine("Division: " + c(a, b));

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}