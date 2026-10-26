
using System;
using System.Collections.Generic;
using System.Linq;

class p11
{
    static void Main()
    {
        List<int> numbers = new List<int>()
        {
            15, 8, 4, 21, 12, 7, 2, 10
        };

        var evenNumbers = from n in numbers
                          where n % 2 == 0
                          orderby n ascending
                          select n;

        Console.WriteLine("Even numbers in ascending order:");

        foreach (int n in evenNumbers)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}
