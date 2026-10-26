
using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}

class p8
{
    static void Main()
    {
        double balance = 5000;

        try
        {
            Console.WriteLine("Available Balance: " + balance);
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > balance)
            {
                throw new InsufficientBalanceException(
                    "Insufficient balance!");
            }

            if (amount <= 0)
            {
                Console.WriteLine("Enter a valid amount.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine("Remaining Balance: " + balance);
            }
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Hiral Sanghani");
        Console.WriteLine("24SOECE11035");
    }
}
