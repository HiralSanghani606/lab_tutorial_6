
using System;
using System.Collections.Generic;

class p10
{
    static void Main()
    {
        List<int> marks = new List<int>()
        {
            45, 75, 60, 30, 90, 50, 85
        };

        Console.WriteLine("Marks greater than 50:");

        marks.FindAll(m => m > 50)
             .ForEach(m => Console.WriteLine(m));

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}
