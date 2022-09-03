System.Console.WriteLine("Введите ширину массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
  for (int index = 0; index < n; index++)
  {
    array[i, index] = new Random().Next(0, 100);
  }
}

System.Console.WriteLine("Введите строку: ");
int stroka = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите столбец: ");
int stolbec = Convert.ToInt32(Console.ReadLine());
if (stroka > m && stolbec > n)
{
    Console.WriteLine("Нету");
}
else
{
    System.Console.WriteLine("Есть");
}