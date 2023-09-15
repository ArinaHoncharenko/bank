using System;
using System.IO;
using System.Threading;

namespace bank
{
    class Program
    {
        public static void Main()
        {
            BankAccount account = new BankAccount();

            // Перевірка наявності файлу з даними
            if (File.Exists(@"C:\Users\1\source\repos\oop2_bank\data.txt"))
            {
                double data = Convert.ToDouble(File.ReadAllText(@"C:\Users\1\source\repos\oop2_bank\data.txt"));
                account.balance = data;
            }

            while (true)
            {
                Console.WriteLine("\tMenu:\n 1. Deposit Funds\n 2. Withdraw Funds\n 3. Show Account Information\n 4. Exit\n Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("\nEnter the amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            account.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine(" Invalid input format.\n");
                        }
                        break;
                    case "2":
                        Console.Write("\n Enter the amount to withdraw: ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            account.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine(" Invalid input format.\n");
                        }
                        break;
                    case "3":
                        account.AccountInfo();
                        break;
                    case "4":
                        Console.WriteLine("\n Thank you for using our services. Goodbye!");
                        Thread.Sleep(4000); // Затримка в 4 секунди перед завершенням
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(" Invalid choice. Please try again.\n");
                        break;
                }

                // Збереження балансу в файлі
                File.WriteAllText(@"C:\Users\1\source\repos\oop2_bank\data.txt", account.balance.ToString());
            }
        }
    }
}
