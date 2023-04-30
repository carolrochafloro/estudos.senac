internal class Program
{
  private static void Main(string[] args)
  {
    
    double gas, alcool, result;
    bool novoCalculo = true;
    string resposta;

    do 
    { 
    Console.WriteLine("Digite o preço do álcool:");
    alcool = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o preço da gasolina:");
    gas = double.Parse(Console.ReadLine());

    result = (alcool/gas);

    if (result > 0.7) 
    {
      Console.WriteLine("Abasteça com gasolina");
    }

    else if (result < 0.7) 
    {
      Console.WriteLine("Abasteça com álcool.");
    }

    else 
    {
      Console.WriteLine("Tanto faz");
    }

    Console.WriteLine("Pressione <N> para calcular novamente ou <S> para sair");
    resposta = Console.ReadLine();

    if (resposta.ToUpper() != "N") 
    {
      novoCalculo = false;
    }
    }
    while (novoCalculo);

  }
  }