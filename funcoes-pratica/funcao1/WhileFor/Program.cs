internal class Program
{

 
 public static int multiplicacao (int n1, int n2, int n3) {
//criada a função, os parâmetros se comportam como variáveis, são chamados de variáveis locais
  int result = n1 * n2 * n3;
  //retorno esperado tem que ser declarado, igual ao esperado (int)
  return result;

 }
  public static void Main(string[] args)
  {
  	Console.WriteLine("Digite o 1º número:");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 2º número:");
    int b = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 3º número:");
    int c = int.Parse(Console.ReadLine());

    //p/ chamar a função você cria uma variável e atribui a ela a função, depois dá os dados esperados. Passagem de parâmetro por valor: copia o conteúdo dessas variáveis para os parâmetros da função.
    int valor = multiplicacao (a, b, c);

    Console.WriteLine ("O resultado é: {0}", valor);

//p/ não encerrar logo após retornar o valor esperado, tem que estar dentro do main.
Console.ReadKey();

}


  }
