Console.WriteLine("ВВедите длинну массива");

int ArrayLenght = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[ArrayLenght];

int ArrayMax = 0;

for (int i = 0; i < ArrayLenght; i++)
{
    Console.WriteLine("Введите число " + i + "го значения массива");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < ArrayLenght; i++)
{
    if (Array[i] > ArrayMax)
    {
        ArrayMax = Array[i];
    }
}
Console.WriteLine(ArrayMax);
