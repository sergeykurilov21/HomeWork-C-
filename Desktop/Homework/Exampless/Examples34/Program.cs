int [] array = new int [4];


RandomArrayy(array);
Console.WriteLine(string.Join(" " ,array));

void RandomArrayy(int [] array)
{
    Random random = new Random();
    int sumNum=0;
    for(int i = 0; i<array.Length;i++)
    {     

        array[i]=random.Next(99,999);
         if((array[i]%2)==0)
        {
            sumNum++;       
        }
        
     
    }
     Console.WriteLine($"Четных чисел в масиве {sumNum}") ;
}


