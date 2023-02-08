
Colculate(ReadInt("number"));

int ReadInt(string argument)
{
    Console.Write($"Введите {argument}:");
    int number;

    while(!int.TryParse(Console.ReadLine(),out number))
    {
        Console.WriteLine("Это не число");
    }

    return number;
           
}  

int Colculate(int number)
{
    int sum = 0;

    for (int i = 1; i<=number ; i++)
    {
       Console.WriteLine(Math.Pow(i,3));
    }
    return sum;
}