// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int firstLength = 3;
int secondLength = 4;

double[,] array = CreateTwoDimensionArray(firstLength, secondLength);
Console.WriteLine(TwoDimensionArrayToString(array));

double[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
  double[,] result = new double[firstLength, secondLength];
  Random rand = new Random();

  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = Math.Round(rand.NextDouble() * 10, 1);
    }
  }

  return result;
}

string TwoDimensionArrayToString(double[,] array)
{
  string result = string.Empty;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result += $"{array[i, j]} ";
    }

    result += Environment.NewLine;
  }

  return result;
}