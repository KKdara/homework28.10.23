using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace lab9
{
    public class BankAccount
    {
        private static int Counter = 1001;
        public decimal Balance { get; set; }
        public string Type { get; set; }
        public int AccountNumber;
        public Queue<BankTransaction> history = new Queue<BankTransaction>();

        private int SetAccountNumber()
        {
             return Counter++;
        }

        public BankAccount()
        {
            AccountNumber = SetAccountNumber();
           
        }
        public BankAccount(decimal balance)
        {
            Balance = balance;
            AccountNumber = SetAccountNumber();
 
        }

        public BankAccount(string type)
        {
            AccountNumber = SetAccountNumber();
            Type = type;
        }

        public BankAccount(decimal balance, string type)
        {
            Balance = balance;
            Type = type;
            AccountNumber = SetAccountNumber();           
        }

        public void Print()
        {
            Console.WriteLine($"ID:{AccountNumber} \nBalance: {Balance} \nType: {Type}");
        }
        public void EmptyMoney(decimal sum)
        {
            if (sum > Balance)
            {
                Console.WriteLine("Unable to withdraw money. The requested amount exceeds the balance.");
            }
            else
            {
                Balance = Balance - sum;
                BankTransaction transaction = new BankTransaction(sum);
                history.Enqueue(transaction);
                Console.WriteLine($"Withdrawal: {sum} \nCurrent balance: {Balance}");
            }
        }

        public void MakeContribution(decimal sum)
        {
            if (sum < 0)
            {
                Console.WriteLine("Negative value. Impossible to contribute.");
            }
            else
            {
                Balance = Balance + sum;
                BankTransaction transaction = new BankTransaction(sum);
                history.Enqueue(transaction);
                Console.WriteLine($"Credited: {sum} \nCurrent balance: {Balance}");
            }
        }
        
        public void Dispose()
        {
            string file = "Transactions.txt";
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (BankTransaction transaction in history)
                {
                    writer.WriteLine($"Date and time: {transaction.date_time} Sum: {transaction.sum}");
                }
            }
            GC.SuppressFinalize(this);
            // с файлом что-то непонятное. вроде, пишу всё правильно, но по каким-то причинам он создаваться не хочет, поэтому хотелось бы решить этот вопрос на защите
        }
 
    }
}

