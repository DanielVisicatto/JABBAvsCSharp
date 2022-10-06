/*
Faça um Programa que leia um vetor de 6 caracteres,
e diga quantas consoantes foram lidas.
Imprima as consoantes.
*/

int qtdConsoantes = 0, count = 0;
string[] consoantes = new string[6];

do
{
    Console.WriteLine("Letra: ");
    string letra = Console.ReadLine();

    if (!(letra.Equals("a", StringComparison.InvariantCultureIgnoreCase) ||
         letra.Equals("e", StringComparison.InvariantCultureIgnoreCase) ||
         letra.Equals("i", StringComparison.InvariantCultureIgnoreCase) ||
         letra.Equals("o", StringComparison.InvariantCultureIgnoreCase) ||
         letra.Equals("u", StringComparison.InvariantCultureIgnoreCase)) )
    {
        consoantes[count] = letra;
        qtdConsoantes++;
    }

    count++;

} while (count < consoantes.Length);

Console.Write("Consoantes: ");
foreach(string consoante in consoantes)
{
    if(consoante != null)
    {
        Console.Write($"{consoante}, ");
    }
}

Console.WriteLine();
Console.Write("Qte de Consoantes: {0}\n", qtdConsoantes);
Console.WriteLine("Tamanho do array: {0}",consoantes.Length);