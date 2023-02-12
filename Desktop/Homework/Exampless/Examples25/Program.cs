
int CalculateNumber(int number, int num){
  int result = 1;
  for(int i=1; i <= num; i++){
    result = result * number;
  }
    return result;
}

  Console.Write("Введите число: ");
  int number = Convert.ToInt16(Console.ReadLine());
  Console.Write("Введите степень: ");
  int num = Convert.ToInt16(Console.ReadLine());

  int sum = CalculateNumber(number, num);
  Console.WriteLine("Получилось: " + sum);
