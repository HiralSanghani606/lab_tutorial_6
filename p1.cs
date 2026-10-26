using System;

interface IEmployee
{
    void GetEmpDetails();
    void ShowEmpDetails();
}

class Employee : IEmployee
{
    int age;
    string name;
    string designation;

    public void GetEmpDetails()
    {
        Console.Write("Enter Employee Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Employee Designation: ");
        designation = Console.ReadLine();
    }

    public void ShowEmpDetails()
    {
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Designation: " + designation);
    }
}

class p1
{
    public static void Main()
    {
        Employee emp = new Employee();
        emp.GetEmpDetails();
        emp.ShowEmpDetails();

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");

    }
}