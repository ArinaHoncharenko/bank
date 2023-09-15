using System;
using System.IO;
using System.Threading;
using bank;

namespace bank
{
    internal class BankAccount
    {
        // ��������� ����� �������
        public int AccountNumber = 34455864;
        // �������� ������ �� �������
        public double balance;

        // ����������� �����
        public BankAccount()
        {
            balance = 0;
        }

        // ����� ��� ���������� ������� �������
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"\n Your account has been credited with {amount} UAH.\n Current balance: {balance} UAH.\n");
        }

        // ����� ��� ������ ������ � �������
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

        // ����� ��� ��������� ���������� ��� �������
        public void AccountInfo()
        {
            Console.WriteLine($"\n Account Number: {AccountNumber}.\n Current Balance: {balance} UAH.\n");
        }
    }

}