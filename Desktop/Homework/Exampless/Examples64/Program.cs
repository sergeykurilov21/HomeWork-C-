// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.






int n = ReadInt("N");

int m = 1;

if (n < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(NaturalNumber(n, m));


int ReadInt(string argument)
{
    Console.Write($"Input {argument} :");
    int n;

    while(!int.TryParse(Console.ReadLine(),out n))
    {
        Console.Write("Oooops,sorry");
    }
    return n;
}

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

