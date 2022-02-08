using System;

namespace ExercicioUm.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            int x = 15;
            double[] alturas = new double[15]; // Criação do Array
            double mAlto=0, mBaixo=10000;

            // Entradas

            Console.WriteLine("..:: Mais alto, mais baixo ::..");
            for(int i = 0; i < x; i++) // Leitura de 15 alturas
            {
                Console.WriteLine("Digite a " + (i+1) + "ª altura: ");
                alturas[i] = double.Parse(Console.ReadLine());
                if(alturas[i] < mBaixo)
                {
                    mBaixo = alturas[i];
                }
                if(alturas[i] > mAlto)
                {
                    mAlto = alturas[i];
                }
            }
            Console.Clear();
            Console.WriteLine("O mais baixo tem: " + mBaixo + "m de altura.\nO mais alto tem: " + mAlto + "m de altura.");
        }
    }
}