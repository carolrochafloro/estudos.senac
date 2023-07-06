using System;
using System.Globalization;

namespace Pratica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, m;
            int max, min;
            int soma = 0;

            do
            {
                string[] vet = Console.ReadLine().Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);
                soma = 0;

                if (m > 0 && n > 0)
                {
                    if (m < n)
                    {
                        max = n;
                        min = m;
                    }
                    else
                    {
                        max = m;
                        min = n;
                    }

                    for (int i = min; i <= max; i++)
                    {
                        Console.Write(i + " ");
                        soma = soma + i;
                    }
                    Console.WriteLine("Sum=" + soma);
                }

            } while (m > 0 && n > 0);
        }
    }
}








