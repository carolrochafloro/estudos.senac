internal class Program
{
  private static void Main(string[] args)
  {
  
    int numcliente;
    int contador = 0;

     Console.WriteLine("Digite o número:");
    numcliente = int.Parse(Console.ReadLine());


    while (contador <= numcliente)
    {
    if (contador % 2 == 0) {Console.WriteLine("Os números pares são: " + contador);
    }
      contador ++;
    }
    Console.ReadKey();
  }
}