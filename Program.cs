using System;
using System.Collections.Generic;
using Curso.Entities;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }

                else
                {
                    Console.Write("Number of employees: ");
                    int employeeNumber = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, employeeNumber));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");

            double sum = 0;;
            foreach (Payer payer in list)
            {
                double tax = payer.TaxesPaid();
                Console.WriteLine(payer.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));
            

            // Apenas para o console não fechar.
            Console.ReadLine();
        }
    }
}