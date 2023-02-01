Console.Write("Введите число: ");
int.TryParse(Console.ReadLine() , out int a);
if (a%2==0)
{
    Console.Write("Четное");
} 
else{
    Console.Write("Нечетное");
}

