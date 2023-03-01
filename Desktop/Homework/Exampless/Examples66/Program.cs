
int m = ReadInt("Введите M");
int n = ReadInt("Введите N");


Console.WriteLine($"Сумма элементов от {m} до {n} равна :{NaturalNumber(m,n)}");



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

int NaturalNumber(int m, int n)
{
    if (m == n)
        return n;
    return n + NaturalNumber(m, n - 1);
}