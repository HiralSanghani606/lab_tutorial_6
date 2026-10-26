
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id;
    public string Name;
    public string Course;
    public int Marks;
}

class p12
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Hiral",
                Course = "BCA", Marks = 85 },

            new Student { Id = 2, Name = "Mital",
                Course = "BSc", Marks = 65 },

            new Student { Id = 3, Name = "Dhara",
                Course = "BCA", Marks = 90 },

            new Student { Id = 4, Name = "Riya",
                Course = "BSc", Marks = 75 }
        };

        var result = from s in students
                     where s.Marks > 70
                     orderby s.Marks ascending
                     select s;

        Console.WriteLine("Students scoring above 70:");

        foreach (Student s in result)
        {
            Console.WriteLine("ID: " + s.Id);
            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("Course: " + s.Course);
            Console.WriteLine("Marks: " + s.Marks);
            Console.WriteLine();
        }

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}
