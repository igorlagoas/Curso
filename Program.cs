using System;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> setA = new HashSet<int>();
            HashSet<int> setB = new HashSet<int>();
            HashSet<int> setC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int numberA = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberA; i++)
            {
                setA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            int numberB = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberB; i++)
            {
                setA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            int numberC = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberC; i++)
            {
                setA.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> result = new HashSet<int>(setA);
            result.UnionWith(setB);
            result.UnionWith(setC);

            Console.Write("Total students: " + result.Count);


            // Apenas para o console não fechar.
            Console.ReadLine();
        }
    }
}