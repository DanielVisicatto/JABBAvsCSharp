/*
Faça um Programa que leia 20 números inteiros aleatórios (entre 0 e 100) armazene-os num vetor.
Ao final mostre os números e seus sucessores.
*/

int[] numerosAleatorios = new int[20];
Random rnd = new Random();

for(int i = 0; i < numerosAleatorios.Length; i++)
{
    int numero = rnd.Next(100);
    numerosAleatorios[i] = numero;
}

Console.Write("Numeros Aleatórios: ");
foreach (int numero in numerosAleatorios)
{
    Console.Write(" {0},", numero);
}
Console.WriteLine();

Console.Write("\nAntecessor dos Números Aleatórios: ");
foreach(int numero in numerosAleatorios)
{
    Console.Write(" {0},", numero - 1);
}
Console.WriteLine();

Console.Write("\nSucessor dos Números Aleatórios: ");
foreach (int numero in numerosAleatorios)
{
    Console.Write(" {0},", numero + 1);
}
Console.WriteLine();
