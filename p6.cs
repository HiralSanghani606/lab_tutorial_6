
using System;

class p6
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;
            Console.WriteLine("Division: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}
