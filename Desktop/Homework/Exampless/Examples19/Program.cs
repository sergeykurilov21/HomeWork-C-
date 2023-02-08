PolindrimColculate(ReadInt("number"));

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

void PolindrimColculate(int number)
{
    int rev=0;
    int temp=number;

    while(number > 0)
    {
        int dig = number % 10;
        rev = rev * 10 + dig;
        number = number / 10;
    }
    if(temp==rev)
    {
        Console.Write("Polindrum");
    }
    else
    {
        Console.Write("Not polindrum");
     }
    
    
  
}





