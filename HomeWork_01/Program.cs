System.Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine()!);
double[, ] array = new double[m, n];

void NewArray(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int index = 0; index < n; index++)
    {
      array[i, index] = new Random().NextDouble( ) * 10 + 30;
    }
  }
}
void PrintFirstArray(double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int index = 0; index < n; index++)
      {
        double printFirstArray = Math.Round(array[i, index], 1);
        Console.Write(printFirstArray + " ");
      }
      Console.WriteLine();
}
}

NewArray(array);
PrintFirstArray(array);