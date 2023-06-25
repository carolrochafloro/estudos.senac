using System;
using System.Globalization;


internal class Program
{
    private static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');

        double valor1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
        double valor2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
        double valor3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
        double A, B, C;

        // Primeiro ordenamos os valores em ordem decrescente
        // 1, 2, 3 e 1, 3, 2
        if (valor1 > valor2 && valor1 > valor3)
        {
            A = valor1;
            if (valor2 > valor3)
            {
                B = valor2;
                C = valor3;
            } else
            {
                B = valor3;
                C = valor2;
            }
        } 
        // 2, 1, 3 e 2, 3, 1
        else if (valor2 > valor1 && valor2 > valor3)
        {
            A = valor2;
            if (valor1 > valor3)
            {
                B = valor1;
                C = valor3;
            }
            else
            {
                B = valor3;
                C = valor1;
            }
        } 
        //3, 2, 1, e 3, 1, 2

        else if (valor3 > valor1 && valor3 > valor2)
        {
            A = valor3;

            if (valor2 > valor1)
            {
                B = valor2;
                C = valor1;
            }
            else
            {
                B = valor1;
                C = valor2;
            }
        } else
        {
            A = valor1;
            B = valor2;
            C = valor3;
        }
        

        //primeiro descartar se não formar triângulo

        if (A >= B + C)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        //Se formar triângulo, a primeira estrutura testa em relação aos ângulos
        else
        {
            if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(A, 2) > (Math.Pow(B, 2) + Math.Pow(C, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (Math.Pow(A, 2) < (Math.Pow(B, 2) + Math.Pow(C, 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            //A segunda estrutura if testa em relação aos lados, vai imprimir junto com a anterior, por isso fica em uma estrutura separada.
            //Atenção ao encadeamento, separar as condições. Na primeira vez não separei e só imprimiu uma informação.

            if (A == B && A == C && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}