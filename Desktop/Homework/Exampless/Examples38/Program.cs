double [] createRandArr(int size, int min, int max) 
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
    {
        array[i] = random.Next(min, max+1);
        
    }
    return array;
}


double MaxArr(double [] array)
{
    int max= 0 ;
    for (int i = 0; i < array.Length; i++)
    {
        array[0]=max;
        if(array[i]>max)
        {
            array[i]=max;
        }
    }
    return max;
    Console.WriteLine($"Значение макиммума:{max}");
}

double MInArr(double [] array)
{
    int min= 0 ;
    for (int i = 0; i < array.Length; i++)
    {
        array[0]=min;
        if(array[i]<min)
        {
            array[i]=min;
        }
    }
    return min;
    Console.WriteLine($"Значение миниммума:{min}");
}
double[] array = createRandArr(5, 1, 99);
double minNumber = MInArr(array);
double maxNumber = MaxArr(array);

Console.WriteLine($"Минимальное значение {minNumber}");
Console.WriteLine($"Максимальное значение {maxNumber}");
Console.WriteLine($"Разница максимального и минимального {maxNumber-minNumber}");