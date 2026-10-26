using System;

public delegate void BankDelegate1();
class BankAccount
{
    public event BankDelegate1 DepositEvent;


    public void Deposit(double amount)
    {

        Console.WriteLine("Amount Deposited Successfully ");

            if (DepositEvent == null)
        {
            DepositEvent(); //call event
        }
    }
}

class p5
{

    public static void DisplayMessage()
    {
        Console.WriteLine("Amount deposited successfully!");
    }

    public static void Main()
    {
        BankAccount b = new BankAccount();

        b.DepositEvent += DisplayMessage;

        b.Deposit(1000);

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}