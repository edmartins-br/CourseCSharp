using System;
using BankAccount.Entities;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*=*=*=*=*=*= ACCOUNT MANAGEMENT SYSTEM *=*=*=*=*=*=");
                Console.WriteLine("Enter account data:");

                Console.Write("Account number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Account Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Console.Write("Enter ammount for withdraw: ");
                double ammount = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit, ammount);
                account.Withdraw(ammount);

                Console.WriteLine("New Balance: " + account);

            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("WARNING (ERROR): " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected ERROR: " + e.Message);
            }
        }
    }
}
