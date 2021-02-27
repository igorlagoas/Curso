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
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == 'c') {
                    list.Add(new Product(name, price));
                }

                else if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }

                else
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }  
                
            // Apenas para o console não fechar.
            Console.ReadLine();
        }
    }
}