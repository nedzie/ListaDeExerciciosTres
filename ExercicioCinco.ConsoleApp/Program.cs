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

            Console.Write(fatorial + "!: ");
            for(int i = fatorial; i > 0; i--) 
            {
                res = i * res; // Pegará o número, e irá multiplicando, repetição por repetição
                Console.Write(i);
                if(i > 1)
                {
                    Console.Write(" x ");
                }   
            }
            Console.WriteLine(" = " + res);

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}