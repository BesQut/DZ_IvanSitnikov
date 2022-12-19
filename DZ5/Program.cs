/*
int[] ThrirdNum(int size, int max, int min)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
*/
/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/
// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int CountPlus(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
      if(array[i] % 2 == 0)
        {
            count++;
        }  
    }
    return count;
}

Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Min трехзначный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max трехзначный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = ThrirdNum(size, max, min);
ShowArray(myArray);
int res = CountPlus(myArray);
Console.Write($"Колличество четных чисел в массиве: {res}");
*/
// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/* 
//Поиск нечетных позиций по массиву
int Nechot(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
// Поиск нечетных позиций по индексу
int Nechot(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Min элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max элемент: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = ThrirdNum(size, max, min);
ShowArray(myArray);
int res = Nechot(myArray);
Console.Write($"Сумма нечетных чисел в массиве: {res}");
*/
// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
double[] Array(int size, int max, int min)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    return array;
}

double Razn(double[] array)
{
    double maxtemp = array[0];
    double mintemp = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxtemp)
        {
            maxtemp = array[i];
        }
        else if(array[i] < mintemp)
        {
            mintemp = array[i];
        } 
    } 
    double num = maxtemp - mintemp;
    return num;
}

Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Min трехзначный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max трехзначный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] myArray = Array(size, max, min);
ShowArray(myArray);
double res = Razn(myArray);
Console.Write($"Колличество четных чисел в массиве: {res}");
*/
