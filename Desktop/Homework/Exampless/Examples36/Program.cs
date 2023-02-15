
int [] array = new int [4];


RandomArrayy(array);
Console.WriteLine(string.Join(" " ,array));

void RandomArrayy(int [] array)
{
    Random random = new Random();
    int sumNum=0;
    for(int i = 0; i<array.Length;i++)
    {     
        array[i]=random.Next(0,99);
        if ((i%2)==0)
        {
            continue;
        }
        else
        {
            sumNum+=array[i];
        }
        
     
    }
     Console.WriteLine($"Cумма чисел в нечетных позициях равна: {sumNum}") ;
}