﻿Console.Write("Введите день недели: ");
int.TryParse(Console.ReadLine() , out int a);

if (a==1)
{
    Console.Write("Понедельник(не выходной)-день тяжелый");
}
if (a==2)
{
    Console.Write("Вторник(не выходной)-день тяжелый");
}
if (a==3)
{
    Console.Write("Среда(не выходной)-день тяжелый");
}
if (a==4)
{
    Console.Write("Четверг(не выходной)-день тяжелый");
}
if (a==5)
{
    Console.Write("Пятница(не выходной)-подножми брат");
}
if (a==6)
{
    Console.Write("Суббота(выходной)-победа");
}
if (a==7)
{
    Console.Write("Воскресенье(выходной)-но не такой кайфовый как суббота");
}