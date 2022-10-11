/*Faça um programa que receba a temperatura média os 6 primeiros meses do ano e armazene-as em uma lista.
Após isto, calcule a média semestral das temperaturas e mostre todas as temperaturas acima desta média,
e em que mês elas ocorreram (mostrar o mês por extenso: 1 – Janeiro, 2 – Fevereiro e etc).
*/
using System.Globalization;

List<double> temperaturas = new();

int count = 0;
double temp, media;

while (true)
{
    if (count == 6) break;

    Console.Write("Digite a temperatura: ");
    if (!double.TryParse(Console.ReadLine(), out temp));
    temperaturas.Add(temp);
    count++;
}
Console.WriteLine("==============================\n");

//exibindo todas as temperaturas:
Console.WriteLine("Todas as temperaturas: ");
temperaturas.ForEach(x => Console.Write($"{x} \n"));
Console.WriteLine("==============================");

//calculando e exibindo a média das temperaturas:
media = temperaturas.Average();
Console.Write("Média das temperaturas: {0} \n", media.ToString("F2",
    CultureInfo.InvariantCulture));
Console.WriteLine("==============================");

//exibindo temperaturas acima da média:
Console.WriteLine("Temperaturas acima da média: ");
foreach (double t in temperaturas.Where(x => x > temperaturas.Average()))
{
    Console.Write("{0} \n",t.ToString("F2", CultureInfo.InvariantCulture));
}
Console.WriteLine("==============================");

//exibindo o mes das temperaturas acima da média poe extenso:
Console.WriteLine("Meses das temperaturas acima da média: ");
IEnumerator<double> enumerador = temperaturas.GetEnumerator();

count = 0;
while (enumerador.MoveNext())
{
    temp = enumerador.Current;
    if (temp > media)
    {
        switch (count)
        {
            case 0:
                Console.WriteLine("1 - janeiro: {0}", temp);
                break;
            case 1:
                Console.WriteLine("2 - fevereiro: {0}", temp);
                break;
            case 2:
                Console.WriteLine("3 - março: {0}", temp);
                break;
            case 3:
                Console.WriteLine("4 - abril: {0}", temp);
                break;
            case 4:
                Console.WriteLine("5 - maio: {0}", temp);
                break;
            case 5:
                Console.WriteLine("6 - juhno: {0}", temp);
                break;
            default:
                Console.WriteLine("Não houve temperaturas acima da média.");
                break;
        }
    }
    count++;
}