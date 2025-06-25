double number_1 = double.Parse(Console.ReadLine());

string oper = Console.ReadLine();

double number_2 = double.Parse(Console.ReadLine());

if (oper == "+")
{
    Console.WriteLine(number_1 + number_2);
}
if (oper == "-")
{
    Console.WriteLine(number_1 - number_2);
}
if (oper == "*")
{
    Console.WriteLine(number_1 * number_2);
}
if (oper == "/")
{
    Console.WriteLine(number_1 / number_2);
}
double number_3 = double.Parse(Console.ReadLine());

string oper_2 = Console.ReadLine();

double number_4 = double.Parse(Console.ReadLine());

switch (oper_2)
{
    case "+":
        Console.WriteLine(number_3 + number_4);
        break;
    case "-":
        Console.WriteLine(number_3 - number_4);
        break;
    case "*":
        Console.WriteLine(number_3 * number_4);
        break;
    case "/":
        Console.WriteLine(number_3 / number_4);
        break;
}