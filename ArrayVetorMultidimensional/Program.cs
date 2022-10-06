/*
Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9.
*/

Random rdn = new Random();
int a = 4, b = 4;
int[, ] m = new int[a, b];

for(int i = 0; i < a; i++)
{
    for(int j = 0; j < b; j++)
    {
        m[i, j] = rdn.Next(9);
    }
}

Console.WriteLine("Matriz: ");
for(int i = 0; i < a; i++)
{
    for(int j = 0 ; j < b; j++)
    {
        Console.Write(" {0}", m[i,j]);
    }
    Console.WriteLine();
}
