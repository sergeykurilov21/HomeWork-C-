
int[,] array = CreateTwoDimensionArray(ReadInt("first Length"),ReadInt("second Length"));

PrintArray(array);

int minSumLine = 0;

int sumLine = SumLineElements(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int ReadInt(string argument)
{
    Console.Write($"Input {argument} :");
    int number;

    while(!int.TryParse(Console.ReadLine(),out number))
    {
        Console.Write("Oooops,sorry");
    }
    return number;
}
int[,] CreateTwoDimensionArray(int firstLength,int secondLength)
{
    int[,] array = new int[firstLength,secondLength];
    Random random = new Random();

    for (int i = 0; i < firstLength; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i,j] = random.Next(0,10);
            
        }
    }
    return array;
}



int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}



void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }

    Console.WriteLine();
  }
}

