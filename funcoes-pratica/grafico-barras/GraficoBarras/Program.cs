internal class Program
{
  private static void Main(string[] args)
  {
   graficoBarras(3, 5, 1);
   Console.ReadKey();
  }

  public static void graficoBarras (int v1, int v2, int v3) {
imprimeLinha(v1);
imprimeLinha(v2);
imprimeLinha(v3);
  }

  public static void imprimeLinha(int n) {
    for (int i = 1; i <= n; i++) {
      Console.Write("#");
    }
    Console.WriteLine(" {0}", n);
  }
}