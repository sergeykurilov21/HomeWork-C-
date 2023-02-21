//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int firstLength = 3;
int secondLength = 4;

int.TryParse(Console.ReadLine() , out int number );

int[,] result = CreateTwoDimensionArray(firstLength, secondLength);
Console.WriteLine(SearchNumberInTwoDimensionArray(number));
PrintArray(result);



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

bool SearchNumberInTwoDimensionArray(int number)
{

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (result[i,j]!=number)
            {
                return false;
            }
            else
            {
                return true;
            }
     
        }
        
    }
    return true;
}


void PrintArray(int [,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"В полученном массиве{result[i,j]} Искомое число {number}");
        }
    }      
}