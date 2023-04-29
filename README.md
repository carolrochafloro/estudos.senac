# Desafio de C# para iniciante proposto pelo ChatGPT.

## Observações

- Ao adicionar a possibilidade do usuário repetir o jogo, o ChatGPT orientou:
  "Console.WriteLine("Deseja jogar novamente? (S/N)");
  string resposta = Console.ReadLine().ToUpper();"
  Porém, sem declarar a variável string resposta no início. O uso do "Console.ReadLine().ToUpper();" não funcionou. Observando a forma como foram feitos os demais comandos de Console.ReadLine no código, declarei a variável e utilizei o seguinte comando:
  "Console.WriteLine("Deseja jogar novamente? S/N");
  resposta = Console.ReadLine();"
