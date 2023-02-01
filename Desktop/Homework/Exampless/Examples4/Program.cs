Console.Write("Введите число: ");
int.TryParse(Console.ReadLine() , out int a);

for (int i =1 ; i < a+1 ; i++){
if (i%2==0)
{
Console.Write(i);
}
}
