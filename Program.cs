using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            var vapovapo;
            
            Console.Write("Insira o número de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());
            
            Console.Write("Insira o número de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());
            
            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite os dados da linha " + (i+1) + ".");
                string[] valores = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    matriz[i,j] = int.Parse(valores[j]);

                }
            }

            Console.Write("Digite o número que deseja procurar: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == number) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }


            // Apenas para o console não fechar.
            Console.ReadLine();
        }
    }
}