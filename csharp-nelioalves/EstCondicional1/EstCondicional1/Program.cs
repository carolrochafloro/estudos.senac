using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Uri
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);
            int maior, medio, menor;
            int primeira = int.Parse(vet[0]);
            int segunda = int.Parse(vet[1]);
            int terceira = int.Parse(vet[2]);


            if (A > B && A > C)
            {
                maior = A;

                if (B > C)
                {
                    medio = B;
                    menor = C;
                }
                else
                {
                    medio = C;
                    menor = B;
                }
            }
            else if (B > A && B > C)
            {
                maior = B;
                if (A > C)
                {
                    medio = A;
                    menor = C;
                }
                else
                {
                    medio = C;
                    menor = A;
                }
            }
            else
            {
                maior = C;

                if (A > B)
                {
                    medio = A;
                    menor = B;
                }
                else
                {
                    medio = B;
                    menor = A;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(primeira);
            Console.WriteLine(segunda);
            Console.WriteLine(terceira);
        }



    }
}
