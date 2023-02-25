// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// 1. Задать масив с рандомными значениями
// 2.Написать функцию заполнения массива
// 2.1 Прописать условия заполнения по убыванию
//3.Вывести функцию



int ReadInt(string argument)
{
    Console.Write($"Input {argument} :");
    int number;

    while(!int.TryParse(Console.ReadLine(),out number))
    {
        Console.Write("Oooops,try again");
    }
    return number;
}



int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
  int[,] array = new int[firstLength, secondLength];
  Random random = new Random();

  for (int i = 0; i < firstLength; i++)
  {
    for (int j = 0; j < secondLength; j++)
    {
      array[i, j] = random.Next(0, 10);
    }
  }
  return array;

}
void ReserchNumberAndSwithHIs(int[,] array)
{
    int max = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0)/2; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }       
        }
    Console.WriteLine(array);
}
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
int[,] array = CreateTwoDimensionArray(ReadInt("firstLength" ), ReadInt("secondLength"));
PrintArray(array);

ReserchNumberAndSwithHIs(array);
PrintArray(array);