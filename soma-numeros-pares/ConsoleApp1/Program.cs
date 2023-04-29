class Program
{
    public static void Main(string[] args)

    {
        bool jogarNovamente = true;

        do
        {

            int num = -1; //inicializa com um número negativo para entrar no loop
            int soma = 0;
            int tentativas = 3; //número máximo de tentativas
            string resposta;

            while (num < 0 && tentativas > 0)
            {
                Console.WriteLine("Digite um número:");
                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("O número deve ser positivo.");
                    tentativas--;
                    Console.WriteLine("Tentativas restantes: {0}", tentativas);
                }
            }


            if (tentativas == 0) //todas as tentativas foram usadas
            {
                Console.WriteLine("Todas as tentativas foram usadas.");
                return;
            }

            else //foi digitado um número positivo
            {
                for (int i = 0; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        soma += i;
                    }
                }

                Console.WriteLine("A soma dos números pares até {0} é {1}", num, soma);

                Console.WriteLine("Deseja jogar novamente? S/N");
                resposta = Console.ReadLine();

                if (resposta != "S")
                {
                    jogarNovamente = false;
                }
            }
        } while (jogarNovamente);
            Console.WriteLine("O programa foi encerrado.");
        }
        }





