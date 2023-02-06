
Console.Write("Введите трех-значное число: ");
int.TryParse(Console.ReadLine() , out int a);

int sum = (a / 10) %10;

Console.Write(sum);

