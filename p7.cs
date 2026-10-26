
using System;

class p7
{
    static void Main()
    {
        try
        {
            Console.Write("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entered number: " + n);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter an integer.");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}
