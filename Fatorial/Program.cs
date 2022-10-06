/*
Faça um programa que calcule o fatorial de um número inteiro fornecido pelo usuário.
Ex.: 5!= 120 (5 X 4 X 3 X 2 X 1)
*/

int fatorial, multiplicacao = 1;

Console.WriteLine("nº Fatorial: ");
if (!int.TryParse(Console.ReadLine(), out fatorial));

Console.Write("{0}! = ",fatorial);
for(int i = fatorial; i >= 1; i--)
{
    multiplicacao *= i;
}
Console.WriteLine(multiplicacao);