using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 9 para saber sua tabuada: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nO numero digitado foi {num}. Sua tabuada é:");
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine($"{num}x{i} = {i * num}");
                i++;
            }
        }
    }
}
