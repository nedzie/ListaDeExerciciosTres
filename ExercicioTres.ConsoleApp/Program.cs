using System;

namespace ExercicioTres.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = 501, total = 0; ;
            Console.WriteLine("Soma dos ímpares múltiplos de três, de 1 a 500:");
            for(int i = 0; i < q; i++)
            {
                if(i % 2 != 0 && i % 3 == 0)
                {
                    //Console.WriteLine(i); Mostra os números, apenas para conferência
                    total += i;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(total);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}