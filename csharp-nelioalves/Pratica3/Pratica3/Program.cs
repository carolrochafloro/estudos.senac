using System;
using System.Globalization;

namespace Pratica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int somar = 0;
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)

            {
                string[] vet = Console.ReadLine().Split(' ');

                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);


                if (x % 2 == 0)
                {
                    x = x + 1;

                }

                somar = x + 2;

                //precisei considerar as hipóteses de y ser = 0 ou 1, casos em que não seria realizada a soma.

                if (y <= 0)
                {
                    soma = 0;
                } else if (y ==1)
                {
                    soma = x;
                }
                else
                {
                    for (int j = 1; j < y; j++)
                    {

                        soma = x + somar;
                        somar = somar + 2;
                        x = soma;

                    }
                }



                Console.WriteLine(soma);


            }

        }
    }
}
