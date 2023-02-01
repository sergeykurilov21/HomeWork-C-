Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine() , out int a );
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine() , out int b );

if (a > b)
{
    Console.Write("Max = ");
    Console.Write(a);
}
else
{
   Console.Write("Max = ");
   Console.Write(b);
}