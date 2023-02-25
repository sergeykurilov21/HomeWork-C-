int firstLength = ReadInt("First Length");
int secondLength = ReadInt("Second Length");

int[,] array = CreateTwoDimensionArray(firstLength, secondLength);
int[,] function = CalculateArray(firstLength, secondLength);

Console.WriteLine(TwoDimensionArrayToString(array));
Console.WriteLine(TwoDimensionArrayToString(function));

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	int result = 0;

	while (!int.TryParse(Console.ReadLine(), out result))
	{
		Console.WriteLine("Try again");
	}

	return result;
}

int [,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
  int[,] result = new int[firstLength, secondLength];
  Random rand = new Random();

  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = rand.Next(1,10);
    }
  }

  return result;
}

void CalculateArray(int firstLength, int secondLength)
{
    double x =0;
    
    for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j]= array[i,j] + x;
      x =x/secondLength;
    }
  }
}