/*
Faça um programa que leia conjuntos de dois valores,
o primeiro representando o nome do aluno e o segundo representando a sua idade.
(Pare o programa inserindo o valor 0 no campo nome)
*/

string nome;
int idade;

while (true)
{
    Console.WriteLine("Nome: ");
    nome = Console.ReadLine();
    if (nome.Equals("0")) break;

    Console.WriteLine("Idade: ");
    if (!int.TryParse(Console.ReadLine(), out idade)) ;
}
Console.WriteLine("Continua aqui...");
