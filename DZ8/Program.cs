// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
/*
int[,] MassivArray(int n, int m, int min, int max)
{
    int[,] array = new int[n,m];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
          array[i,j] = new Random().Next(min, max + 1);
    return array;
}

int[,] Array(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
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
  }
  return array;
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Min= ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max= ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] res1 = MassivArray(n, m, min, max);
ShowArray(res1);
int[,] res2 = OrderArrayLines(res1);
ShowArray(res2);
*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] MassivArray(int n, int m, int min, int max)
{
    int[,] array = new int[n,m];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
          array[i,j] = new Random().Next(min, max + 1);
    return array;
}

void Array(int[,] array, int n)
{
    int sum = 0;
    int index = 0;
    int[] sumarray = new int[n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = temp + array[i,j];
        }
        if(temp > sum)
        {
            sum = temp;
            index = i + 1;
        }
    }
    Console.Write("С трока с наименьшей суммой= " + index);
}


void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Min= ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max= ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] res1 = MassivArray(n, m, min, max);
ShowArray(res1);
Array(res1, n);
*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.