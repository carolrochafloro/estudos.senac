using System;
using System.Globalization;


namespace EstCondicional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for - quando você sabe a quantidade de repetições
            //for (inicio (só na primeira vez, voltando não roda de novo); condicao (v - executa e volta, f - pula);
            //incremento(executa toda vez depois de voltar)) {
            //comando
            //} 

            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            soma = 0;

            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);

        } //do-while: o bloco de comandos é executado pelo menos 1x, pois a condição é verificada no final.
        // do { comando} while (condição);
    }
}




    
