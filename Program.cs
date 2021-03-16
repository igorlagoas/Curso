using System;
using System.Collections.Generic;
using System.IO;
using Curso.Entities;
using System.Linq;
using System.Globalization;
using System.Collections;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo a ser lido: ");
            string path = Console.ReadLine();

            Console.Write("Digite o salário mínimo a ser exibido: ");
            double salaryMin = double.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            var r1 = list.Where(e => e.Salary > salaryMin).OrderBy(e => e.Email).Select(e => e.Email);
            var r2 = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

            Console.WriteLine($"Os e-mails dos funcionários com salário maior que {salaryMin} são: ");
            foreach (IEnumerable email in r1)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine();

            Console.WriteLine("A soma dos salários dos funcionários que começam com a letra 'M' é: R$ " + r2.ToString("F2", CultureInfo.InvariantCulture));

            // Apenas para o console não fechar.
            Console.ReadLine();
        }
    }
}