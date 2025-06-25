Console.Write("Укажите размер массива:\t");

int ArrayLenght = int.Parse(Console.ReadLine());

int[] Array = new int[ArrayLenght];

for (int i = 0; i < ArrayLenght; i++)
{
    Console.WriteLine("Введите число " + i + "го значения массива");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Array.Length);

int Counter = 0;
int k = 0;
for (int j = 0; j < Array.Length; j++)
{

}
Console.WriteLine(Counter);