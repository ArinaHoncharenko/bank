using System;
using System.IO;
using System.Threading;
using bank;

namespace bank
{
    internal class BankAccount
    {
        // Унікальний номер рахунку
        public int AccountNumber = 34455864;
        // Поточний баланс на рахунку
        public double balance;

        // Конструктор класу
        public BankAccount()
        {
            balance = 0;
        }

        // Метод для поповнення балансу рахунку
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"\n Your account has been credited with {amount} UAH.\n Current balance: {balance} UAH.\n");
        }

        // Метод для зняття грошей з рахунку
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"\n You have withdrawn {amount} UAH.\n Current balance: {balance} UAH.\n");
            }
            else
            {
                Console.WriteLine("\n Insufficient funds in the account.\n");
            }
        }

        // Метод для виведення інформації про рахунок
        public void AccountInfo()
        {
            Console.WriteLine($"\n Account Number: {AccountNumber}.\n Current Balance: {balance} UAH.\n");
        }
    }

}