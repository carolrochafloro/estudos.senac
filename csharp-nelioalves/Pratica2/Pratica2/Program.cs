using System;

namespace Pratica2NaoSubir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int contador = 1;

            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int soma = x;
            int proximo = x + 1;

            while (n <= x)
            {
                n = int.Parse(Console.ReadLine());

            }

            while (soma <= n)
            {
                contador++;

                soma = soma + proximo;

                proximo = proximo + 1;

            }



            Console.WriteLine(contador);

        }
    }
}