Console.WriteLine("Какой высоты будет треугольник?");
int hight = int.Parse(Console.ReadLine());

for (int i = 1; i < hight; i++)
{
    for (int j = 0; j < i; j++)
    { Console.Write("#"); }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 1; i < hight; i++)
{
    for (int j = hight; i < j; j--)
    { Console.Write("$"); }
    Console.WriteLine();
}

Console.WriteLine("Какой высоты будет треугольник?");
int hight2 = int.Parse(Console.ReadLine());

for (int i = 1; i < hight2; i++)
{
    for (int j = hight2; j > i; j--)
    { Console.Write("2"); }
    for (int k = 0; k < i; k++)
    { Console.Write("@"); }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 1; i < hight2; i++)
{
    for (int j = 0; j < i; j++)
    { Console.Write("2"); }
    for (int k = hight2; k > i; k--)
    { Console.Write("@"); }
    Console.WriteLine();
}
Console.ReadLine();
