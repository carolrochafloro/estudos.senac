internal class NotaAluno
{
  static void Main(string[] args)
  {
    double nota1, nota2, nota3, media;
    string nomeAluno;

    { 
    Console.WriteLine("Digite o nome do aluno");
    nomeAluno = (Console.ReadLine());

    Console.WriteLine("Digite a primeira nota:");
    nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a segunda nota:");
    nota2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a terceira nota:");
    nota3 = double.Parse(Console.ReadLine());

    media = (nota1 + nota2 + nota3) / 3;

    if (media >= 6)
    {
      Console.WriteLine("O aluno " + nomeAluno + " está aprovado!");
    }

    else
    {
      Console.WriteLine("O aluno " + nomeAluno + " está reprovado!");
    }
    Console.ReadLine();
    }

   
  }
}
