/*
Crie um vetor de 6 números inteiros         ex 1 2 3 4 5
e mostre-os na ordem inversa.               ex 5 4 3 2 1
*/

int[] array = { -5, -6, 15, 50, 8, 4 };
int count = 0;

Console.Write("Vetor na ordem normal: ");

while(count < array.Length)
{
    Console.Write($"{array[count++]} ");
}
Console.WriteLine();

Console.Write("\nVetor de trás para frente: ");
for(int i = array.Length - 1; i >= 0; i--)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
