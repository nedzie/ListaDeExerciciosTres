using System;

namespace ExercicioCinco.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fatorial=0;
            int res = 1;

            Console.WriteLine("Digite um número para saber seu ¡fatorial!: ");
            fatorial = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for(int i = fatorial; i > 0; i--) // Pegará o número, e irá multiplicando, repetição por repetição
            {
                res = i * res;
                Console.Write(i);
                if(i > 1)
                {
                    Console.Write(" x ");
                }   
            }
            Console.WriteLine(" = " + res);
            Console.ResetColor();
        }
    }
}