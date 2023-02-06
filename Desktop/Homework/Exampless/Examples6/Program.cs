Console.Write("Введите число: ");
int.TryParse(Console.ReadLine() , out int a);
string sum = Convert.ToString(a);
if (a<99)
{
    Console.Write("Число не 3-х значное,попробуйtе снова");
}
//int sum =0;
//if (a > 99)
//{
//    sum = a %10 ;
//}
//if ( a<99)
//{
//    Console.Write("Число не 3-х значное");
//}

Console.Write(sum[2]);