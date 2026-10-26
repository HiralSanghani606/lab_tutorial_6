using System;

delegate void StudentDetails();

class p4
{
    public static string name;
    public static string course;
    public static int semester;
    static void DisplayName()
    {
        Console.WriteLine("Enter name : ");
        name = Console.ReadLine();
        Console.WriteLine("Student Name: " + name);
    }

    static void DisplayCourse()
    {
        Console.WriteLine("Enter course : ");
        course = Console.ReadLine();
        Console.WriteLine("Course: " + course);
    }

    static void DisplaySemester()
    {
        Console.WriteLine("Enter semester : ");
        semester = int.Parse(Console.ReadLine());
        Console.WriteLine("Semester: " + semester);
    }

    static void Main()
    {
        StudentDetails s = DisplayName;
        s += DisplayCourse;
        s += DisplaySemester;

        Console.WriteLine("Student Details:");
        s();                 //call all methods

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
        Console.ReadLine();
    }
}