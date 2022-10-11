/*
Utilizando listas, faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
1. "Telefonou para a vítima?"
2. "Esteve no local do crime?"
3. "Mora perto da vítima?"
4. "Devia para a vítima?"
5. "Já trabalhou com a vítima?"
Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como
"Cúmplice" e 5 como "Assassina". Caso contrário, ele será classificado como "Inocente".
*/

using System.Runtime.CompilerServices;

List<string> respostas = new();
string resposta;

Console.WriteLine("Perguntas: ");
Console.Write("Telefonou para a vítima?: ");
resposta = Console.ReadLine();
respostas.Add(resposta.ToLower());

Console.Write("Esteve no local do crime?: ");
resposta = Console.ReadLine();
respostas.Add(resposta.ToLower());

Console.Write("Mora perto da vítima?: ");
resposta = Console.ReadLine();
respostas.Add(resposta.ToLower());

Console.Write("Devia para a vítima?: ");
resposta = Console.ReadLine();
respostas.Add(resposta.ToLower());

Console.Write("Já trabalhou com a vítima?: ");
resposta = Console.ReadLine();
respostas.Add(resposta.ToLower());

Console.WriteLine("Suas respostas: ");
foreach (string res in respostas) 
{
    Console.Write($"{res}, "); 
}


IEnumerator<string> contador = respostas.GetEnumerator();
int count = 0;

while (contador.MoveNext())
{
    string resp = contador.Current;
    if(resp.Contains("s"))
        count++;
}

switch (count)
{
    case 2:
        Console.WriteLine(">> SUSPEITO! <<");
        break;
    case 3:       
    case 4:
        Console.WriteLine(">> CÚMPLICE! <<");
        break ;
    case 5:
        Console.WriteLine(">> ASSASSINO! <<");
        break;
        default:
        Console.WriteLine(">> INOCENTE... <<");
        break;

}     
