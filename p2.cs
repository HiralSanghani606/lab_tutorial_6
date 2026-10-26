using System;

interface IPersonalDetails
{
    void GetPersonalDetails();
    void ShowPersonalDetails();
}

interface IProfessionalDetails
{
    void GetProfessionalDetails();
    void ShowProfessionalDetails();
}

class Employee1 : IPersonalDetails, IProfessionalDetails
{
    string name;
    string email;
    int age;
    double salary;
    int no_of_exp;

    public void GetPersonalDetails()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Email: ");
        email = Console.ReadLine();

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }

    public void ShowPersonalDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Age: " + age);
    }

    public void GetProfessionalDetails()
    {
        Console.Write("Enter Salary: ");
        salary = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of years experience: ");
        no_of_exp = Convert.ToInt32(Console.ReadLine());
    }

    public void ShowProfessionalDetails()
    {
        
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Number of years experience: " + no_of_exp);
    }
}



class p2
{
    static void Main()
    {
        Employee1 e = new Employee1();

        e.GetPersonalDetails();
        e.ShowPersonalDetails();
        e.GetProfessionalDetails();
        e.ShowProfessionalDetails();

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}