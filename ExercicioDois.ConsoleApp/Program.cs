using System;

namespace ExercicioDois.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=0; // Cosmético
            for(int i = 100; i <= 200; i++)
            {
                if(i % 2 != 0)
                {
                    x++;
                Console.WriteLine(x + "º ímpar: " + i);
                }
            }
            Console.ReadKey();
        }
    }
}