/*
Faça um programa que peça uma nota, entre zero e dez.
Mostre uma mensagem caso o valor seja inválido
e continue pedindo
até que o usuário informe um valor válido.
*/

int nota;

Console.WriteLine("Nota");
if (!int.TryParse(Console.ReadLine(), out nota));

while (nota < 0 || nota > 10)
{
    Console.WriteLine("Nota Inválida! Digite Novamente: ");
    if (!int.TryParse(Console.ReadLine(), out nota)) ;
}
