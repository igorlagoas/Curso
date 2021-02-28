using System;
using System.Collections.Generic;
using Curso.Entities;
using System.Globalization;
using Curso.Exceptions;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Inicial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account =  new Account(number, holder, initialBalance, withdrawLimit);
            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            
            try 
            {
                account.Withdraw(amount);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

            Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));


            // Apenas para o console não fechar.
            Console.ReadLine();
        }
    }
}