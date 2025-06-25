Console.WriteLine("Из какого числа необходмо узнать кол-во четных и нечетных чисел?");
int input_number = int.Parse(Console.ReadLine());
int start_number = 0;
int chet = 0, nechet = 0;
while (input_number >= start_number)
{
    start_number++;
    if (start_number % 2 == 0)
    {
        chet++;
    }
    else
    {
        nechet++;
    }
}
Console.WriteLine(chet);
Console.WriteLine(nechet);