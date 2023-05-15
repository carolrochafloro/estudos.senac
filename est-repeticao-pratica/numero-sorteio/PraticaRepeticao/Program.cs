internal class Program
{
  private static void Main(string[] args)

  {
    Random randNum = new Random();
    int sorteio = randNum.Next(10);
    int usuario;
    int tentativas = 5;

    while (tentativas > 0) {
 Console.WriteLine("Digite um número:");
    usuario = int.Parse(Console.ReadLine());

     if (usuario == sorteio) {
      Console.WriteLine("Parabéns! Se deseja sair, pressione <esc>");
      ConsoleKeyInfo key = Console.ReadKey();
      if (key.Key == ConsoleKey.Escape) {
        break;
      }


    }
  else {
 Console.WriteLine("Você errou, tente novamente ou digite <esc> para sair.");
  ConsoleKeyInfo key = Console.ReadKey();
      if (key.Key == ConsoleKey.Escape) {
        break;
      }

 tentativas = tentativas - 1;
      }
    }
    Console.WriteLine("O número sorteado era: " + sorteio);
    Console.ReadKey();
    }

  }
  