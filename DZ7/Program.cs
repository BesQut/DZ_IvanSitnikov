// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void MassivArray(int n, int m, int max, int min)
{
    
    if(m > 0 && n > 0) 
    {
        double[,] array = new double[n,m];
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = Math.Round(new Random().Next(min, max + 1) + new Random().NextDouble(),2);
                Console.Write(array[i,j] + "\t");
            }
            Console.WriteLine(); 
        }       
    }
    else
    {
        Console.Write("Не корректный массив");
    }
}


Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Min= ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max= ");
int max = Convert.ToInt32(Console.ReadLine());

MassivArray(n, m, max, min);
*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
void MassivArray(int n, int m, int max, int min, int a, int b)
{
    int[,] array = new int[n,m];
    if(a < m && b < n)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(min, max + 1);
                Console.Write(array[i,j] + "\t");
            }
            Console.WriteLine();
        }
        Console.Write(array[a,b] + "\t");
    }
    else
    {
        Console.Write("Нет числа в заданных пользователем индексов");
    }
}

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Min= ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max= ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Первый индекс: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второй индекс: ");
int b = Convert.ToInt32(Console.ReadLine());

MassivArray(n, m, max, min, a, b);
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
double[] CreateRandomArray(int n, int m,int max, int min)
{

    double[] createArray = new double[m];
    double[,] array = new double[n,m];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            array[i,j] = new Random().Next(0, 11);
            sum = sum + array[i,j];
        }
        createArray[j] = sum / array.GetLength(0);
    }
    
    return createArray;
}

void ShowArray(double[] createArray)
{
    for(int i = 0; i < createArray.Length; i++)
    {
        Console.Write(createArray[i] + "\t");
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

double[] res = CreateRandomArray(n, m, max, min);
ShowArray(res);
*/
