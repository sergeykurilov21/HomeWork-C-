﻿Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine() , out int a );
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine() , out int b );
Console.Write("Введите третье число: ");
int.TryParse(Console.ReadLine() , out int c );
int max = a;
if (a> max) max = a;
if (b> max) max = b;
if (c> max) max = c;
Console.Write("Max=");
Console.Write(max);
