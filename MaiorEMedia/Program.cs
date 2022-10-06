/*
Faça um programa que leia 5 números
e informe o maior número
e a média desses números.
*/

int numero, maior =0, soma =0, count =0;

do
{
    Console.WriteLine("Número: ");
    if (!int.TryParse(Console.ReadLine(), out numero));

    soma += numero;

    if (numero > maior) maior = numero;

    count++;
} while (count < 5);
Console.WriteLine("Maior: {0}", maior);
Console.WriteLine("Média: {0}", soma / count);
