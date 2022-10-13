/*
Crie uma conjunto contendo as cores do arco-íris e:
a) Exiba todas as cores o arco-íris uma abaixo da outra;
b) A quantidade de cores que o arco-íris tem;
c) Exiba as cores em ordem alfabética;
d) Exiba as cores na ordem inversa da que foi informada;
e) Exiba todas as cores que começam com a letra ”v”;
f) Remova todas as cores que não começam com a letra “v”;
g) Limpe o conjunto;
h) Confira se o conjunto está vazio;
 */

using System.Collections.ObjectModel;

Console.WriteLine("Crie um cinjunto contendo as cores do Arco-iris:");
ISet<string> coresArcoIris = new HashSet<string>();
coresArcoIris.Add("violeta");
coresArcoIris.Add("anil");
coresArcoIris.Add("azul");
coresArcoIris.Add("verde");
coresArcoIris.Add("amarelo");
coresArcoIris.Add("laranja");
coresArcoIris.Add("vermelho");
foreach(string cor in coresArcoIris)
    Console.Write($"{cor} -");
Console.WriteLine("\n==============================");
Console.WriteLine();

Console.WriteLine("Exiba todas as cores o Arco-íris uma abaixo da outra: ");
foreach (string cor in coresArcoIris)
    Console.WriteLine(cor);
Console.WriteLine("==============================");
Console.WriteLine();

Console.WriteLine("A quantidade de cores que o Arco-íris tem: {0}", coresArcoIris.Count);
Console.WriteLine("==============================");
Console.WriteLine();

Console.WriteLine("Exiba as cores e ordem alfabética:");
ISet<string> coresOrdenadas = new SortedSet<string>(coresArcoIris);
foreach(var cor in coresOrdenadas)
    Console.Write($"{cor} - ");
Console.WriteLine("\n==============================");
Console.WriteLine();

Console.WriteLine("Exiba as cores na ordem inversa da que foi informada:");
LinkedList<string> coresOrdemRecebida = new LinkedList<string>();
coresOrdemRecebida.AddFirst("violeta");
coresOrdemRecebida.AddLast("anil");
coresOrdemRecebida.AddLast("azul");
coresOrdemRecebida.AddLast("verde");
coresOrdemRecebida.AddLast("amarelo");
coresOrdemRecebida.AddLast("laranja");
coresOrdemRecebida.AddLast("vermelho");
foreach(var cor in coresOrdemRecebida)
    Console.Write($" {cor} -> ");
Console.WriteLine("\n==============================");
List<string> coresOrdemInvertida = new List<string>(coresOrdemRecebida.Reverse());
foreach (var cor in coresOrdemInvertida)
    Console.Write($" <- {cor} ");
Console.WriteLine("\n==============================");
Console.WriteLine();

Console.WriteLine("Exiba todas as cores que começam com a letra V:");
foreach (var cor in coresArcoIris)
    if (cor.StartsWith("v"))
        Console.Write($"- {cor} ");
Console.WriteLine("\n==============================");
Console.WriteLine();

Console.WriteLine("Agora remova todas as cores que começam com a letra V");
var itensComV = coresArcoIris.Where(x => x.StartsWith("v")).ToList();
foreach (var var in itensComV)
    coresArcoIris.Remove(var);       

foreach(var cor in coresArcoIris)
    Console.WriteLine($"- {cor} ");
Console.WriteLine("\n==============================");
Console.WriteLine();

Console.WriteLine("Limpe o conjunto:");
coresArcoIris.Clear();
Console.WriteLine("\n==============================");
Console.WriteLine();

Console.WriteLine("Por fim, confira se o conjunto está vazio: {0}", coresArcoIris.Count is 0);


