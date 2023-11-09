using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 9.1");
            Console.WriteLine("First account:");
            BankAccount account1 = new BankAccount();
            account1.Print();
            Console.WriteLine("\nSecond account:");
            BankAccount account2 = new BankAccount(2000);
            account2.Print();
            Console.WriteLine("\nThird account:");
            BankAccount account3 = new BankAccount("Current");
            account3.Print();
            Console.WriteLine("\nForth account:");
            BankAccount account4 = new BankAccount(50000, "Savings");
            account4.Print();

            Console.WriteLine("\nTask 9.2");
            BankAccount bankAccount = new BankAccount(1000, "Current");
            bankAccount.MakeContribution(1000);
            bankAccount.EmptyMoney(600);

            Console.WriteLine("\nTask 9.3)");
            BankAccount bank = new BankAccount(1300, "Savings");
            bank.MakeContribution(700);
            bank.EmptyMoney(2000);

            Console.WriteLine("\nHome task 9.1");
            Song mySong = new Song();
            Console.WriteLine("(Press any key to continue work)");
            Console.ReadKey();
        }
    }
}
