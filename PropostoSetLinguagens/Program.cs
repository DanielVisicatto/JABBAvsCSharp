/*
Crie uma classe LinguagemFavorita que possua os atributos nome, anoDeCriacao e IDE.
Em seguida, crie um conjunto com 3 linguagens e faça um programa que ordene esse conjunto por:
a) Ordem de inserção;
b) Ordem natural(nome);
c) IDE;
d) Ano de criação e nome;
e) Nome, ano de criação e IDE;
Ao final, exiba as linguagens no console, um abaixo da outra.
*/

using PropostoSetLinguagens.Entities;
using System.Linq;

ISet<LinguagemFavorita> minhasLinguagensFavoritas = new HashSet<LinguagemFavorita>();
minhasLinguagensFavoritas.Add(new LinguagemFavorita("Python", 1991, "Pycharm"));
minhasLinguagensFavoritas.Add(new LinguagemFavorita("JavaScript", 1995, "VsCode"));
minhasLinguagensFavoritas.Add(new LinguagemFavorita("Java", 1991, "IntelliJ"));
minhasLinguagensFavoritas.Add(new LinguagemFavorita("C#", 1999, "VisualStudio"));

Console.WriteLine("--------\tOrdem de Inserção\t--------");
foreach(LinguagemFavorita item in minhasLinguagensFavoritas)
    Console.WriteLine(item.ToString());
Console.WriteLine("======================================");
Console.WriteLine();

Console.WriteLine("--------\tOrdem Natural: Nome\t--------");
ISet<LinguagemFavorita> linguagemFavoritas1 = new SortedSet<LinguagemFavorita>()
{
    new LinguagemFavorita("Python", 1991, "Pycharm"),
    new LinguagemFavorita("JavaScript", 1995, "VsCode"),
    new LinguagemFavorita("Java", 1991, "IntelliJ"),
    new LinguagemFavorita("C#", 1999, "VisualStudio")
};
foreach(var item in linguagemFavoritas1)
    Console.WriteLine(item.ToString());
Console.WriteLine("======================================");
Console.WriteLine();

Console.WriteLine("--------\tOrdem IDE\t--------");
ISet<LinguagemFavorita> linguagemFavoritas2 = new SortedSet<LinguagemFavorita>(new ComparatorIde());
linguagemFavoritas2.UnionWith(minhasLinguagensFavoritas);
foreach(var item in linguagemFavoritas2)
    Console.WriteLine(item.ToString());
Console.WriteLine("======================================");
Console.WriteLine();

Console.WriteLine("----\tOrdem Ano de Criacao e Nome\t----");
ISet<LinguagemFavorita> linguagemFavoritas3 = new SortedSet<LinguagemFavorita>
    (new ComparatorAnoCriacaoENome());
linguagemFavoritas3.UnionWith(minhasLinguagensFavoritas);
foreach (var item in linguagemFavoritas3)
    Console.WriteLine(item.ToString());
Console.WriteLine("======================================");
Console.WriteLine();

Console.WriteLine("-\tOrdem Nome - Ano de Criacao - IDE\t-");
ISet<LinguagemFavorita> linguagemFavoritas4 = new SortedSet<LinguagemFavorita>
    (new ComparatorNomeAnoCriacaoIde());
linguagemFavoritas4.UnionWith(minhasLinguagensFavoritas);
foreach (var item in linguagemFavoritas4)
    Console.WriteLine(item.ToString());
Console.WriteLine("======================================");
Console.WriteLine();

