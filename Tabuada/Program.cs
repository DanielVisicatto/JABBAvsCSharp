/*
Desenvolva um gerador de tabuada,
capaz de gerar a tabuada de qualquer número inteiro entre 1 a 10.
O usuário deve informar de qual numero ele deseja ver a tabuada.
A saída deve ser conforme o exemplo abaixo:

Tabuada de 5:
5 X 1 = 5
5 X 2 = 10
...
5 X 10 = 50
*/

int tabuada;

Console.WriteLine("Qual tabuada? ");
if (!int.TryParse(Console.ReadLine(), out tabuada));

Console.WriteLine();
Console.WriteLine("Tabuada do : {0}\n", tabuada);
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} X {1} = {2}", tabuada, i, (tabuada *i));
}
