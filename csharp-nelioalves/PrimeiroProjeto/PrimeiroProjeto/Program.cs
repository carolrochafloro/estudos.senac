using System;
using System.Globalization;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine armazena a entrada em uma variável tipo string
            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();
            //Parse converte a string pro tipo de variável desejado.
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qts = int.Parse(Console.ReadLine());
            //tem que colocar InvariantCulture na leitura também
            Console.WriteLine("Digite o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Split(' ') divide a linha no espaço, cada palavra vira uma variável no vetor vet[]
            Console.WriteLine("Digite seu último nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string nome1 = vet[0];
            int idade1 = int.Parse(vet[1]);
            //CultureInfo.InvariantCulture -> usa o . em vez da , pra separar casas decimais. Precisa da biblioteca System.Globalization
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(qts);
            //ToString "F2" -> max. 2 casas decimais
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome1);
            Console.WriteLine(idade1);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}