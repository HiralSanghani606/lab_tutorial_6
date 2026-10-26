
using System;
using System.Threading;

class p13
{
    static void DisplayNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Number: " + i);
        }
    }

    static void DisplayAlphabets()
    {
        for (char c = 'A'; c <= 'J'; c++)
        {
            Console.WriteLine("Alphabet: " + c);
        }
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to Multithreading!");
    }

    static void Main()
    {
        Thread t1 = new Thread(DisplayNumbers);
        Thread t2 = new Thread(DisplayAlphabets);
        Thread t3 = new Thread(DisplayMessage);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("All threads completed.");

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}
