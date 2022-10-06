/*
Faça um programa que peça N números inteiros,
calcule e mostre a quantidade de números pares
e a quantidade de números impares.
*/

int quantNumeros, numero, quantPares = 0, quantImpares = 0, count =0;

Console.WriteLine("Quantidade de números: ");
if (!int.TryParse(Console.ReadLine(), out quantNumeros));

do
{
    Console.WriteLine("Número: ");
    if (!int.TryParse(Console.ReadLine(), out numero)) ;

    if (numero % 2 == 0) quantPares++;
    else quantImpares++;

    count++;
}while (count < quantNumeros);

Console.WriteLine("Quantidade de pares: {0}", quantPares);
Console.WriteLine("Quantidade de ímpares: {0}", quantImpares);