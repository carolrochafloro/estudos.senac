using System;
using System.Globalization;

namespace EstRepetitivas

//while: quando não souber o número de repetições. Repete enquanto uma condição for verdadeira.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (condição) {comando a ser repetido. v = executa e volta pra condição. f = pula.}
            int opcao = int.Parse(Console.ReadLine());
            int totalAlcool = 0;
            int totalGasolina = 0;
            int totalDiesel = 0;


            while (opcao != 4)
            {
                if (opcao > 4 || opcao < 0)
                {
                    opcao = int.Parse(Console.ReadLine());
                } else if (opcao == 1) {
                    totalAlcool = totalAlcool + 1;
                    opcao = int.Parse(Console.ReadLine());
                } else if (opcao == 2) {
                    totalGasolina = totalGasolina + 1;
                    opcao = int.Parse(Console.ReadLine());
                } else
                {
                    totalDiesel = totalDiesel + 1;
                    opcao = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + totalAlcool);
            Console.WriteLine("Gasolina: " + totalGasolina);
            Console.WriteLine("Diesel: " + totalDiesel);

        }
    }
}