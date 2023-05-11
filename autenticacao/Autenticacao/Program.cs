internal class Program
{
  private static void Main(string[] args)
  {
    string nome;
    string senha;

    Console.WriteLine("Nome de usuário:");
    nome = Console.ReadLine();

    Console.WriteLine("Senha");
    senha = Console.ReadLine();
    
// && = operador lógico E
    if (nome == "Maria" && senha == "1234"){
      for (int i=0; i<=10; i++) {
        if(i % 2 == 0){
          Console.WriteLine(i);
        }
      }
    }
    else {
      Console.WriteLine("Acesso negado");
    }

    Console.ReadKey();

  }
}