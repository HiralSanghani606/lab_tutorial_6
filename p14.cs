
using System;
using System.Threading;

class p14
{
    static void Display()
    {
        Console.WriteLine("Thread is running.");

        Thread.Sleep(1000);

        Console.WriteLine("Thread task completed.");
    }


    static void Main()
    {
        Thread t = new Thread(Display);

        Console.WriteLine("Before Start: " + t.ThreadState);

        t.Start();

        Console.WriteLine("After Start: " + t.ThreadState);

        t.Join();

        Console.WriteLine("After Join: " + t.ThreadState);

        Console.WriteLine("Thread execution finished.");

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}
