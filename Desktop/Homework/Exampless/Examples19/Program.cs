Console.Write("Введите число: ");
int.TryParse(Console.ReadLine() , out int n);
int temp = n;
int rev = 0;
while(n > 0)
{
    int dig = n % 10;
    rev = rev * 10 + dig;
    n = n / 10;
}
if(temp == rev)
{
    Console.Write("Это палиндром!");
}
else
{
    Console.Write("Это не палиндром!");
}
