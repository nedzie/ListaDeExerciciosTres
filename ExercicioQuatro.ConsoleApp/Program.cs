using System;

namespace ExercicioQuatro.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha=0;
            Console.WriteLine("Digite um número para saber a tabuada: ");
            escolha = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Tabuada do " + escolha + ": ");
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + escolha + " = " + (i*escolha));
            }
            Console.ReadKey();
        }
    }
}