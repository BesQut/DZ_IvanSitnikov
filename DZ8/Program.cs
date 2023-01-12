// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
/*
int[,] CreateArray(int n, int m, int min, int max)
{
    int[,] array = new int[n,m];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(min, max + 1);
    return array;
}

int[,] Newarray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i,k] < array[i,k + 1])
                {
                    int temp = array[i,k + 1];
                    array[i,k + 1] = array[i,k];
                    array[i,k] = temp;
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

int[,] res1 = CreateArray(n, m, min, max);
ShowArray(res1);
int[,] res2 = Newarray(res1);
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

void Array(int[,] array)
{
    int sum = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = temp + array[i,j];
        }
        if(temp > sum)  sum = temp;
        else  index = i + 1;
    }
    Console.Write("Строка с наименьшей суммой= " + index);
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
Array(res1);
*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateArrayA(int n, int m, int min, int max)
{
    int[,] array = new int[n,m];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    return array;
}

int[,] Create2ArrayB(int a, int b, int min, int max)
{
    int[,] NewArray = new int[a,b];
    for(int i = 0; i < NewArray.GetLength(0); i++)
        for(int j = 0; j < NewArray.GetLength(1); j++)
        {
            NewArray[i,j] = new Random().Next(min, max + 1);
        }
    return NewArray;
}

void NewArrayC(int[,] array, int[,] NewArray, int n, int m, int a, int b)
{
    if(array.GetLength(0) > NewArray.GetLength(1) || array.GetLength(0) < NewArray.GetLength(1))
    {
        Console.Write("Введены не коректно массивы");
    }
    else
    {
        int[,] array2 = new int[n,m];
        for(int i = 0; i < array2.GetLength(0); i++)
        {
            int sum = 0;
            for(int j = 0; j < array2.GetLength(1); j++)
            {
                for(int z = 0, k = 0; z < array2.GetLength(1) && k < NewArray.GetLength(0); z++, k++)
                {
                    sum += array[i,z] * NewArray[k,j];
                }
                array2[i,j] = sum;
                Console.Write(array2[i,j] + "\t");
            }
            Console.WriteLine();
        } 
    }
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
Console.Write("Введите количество столбцов: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Min= ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max= ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] res1 = CreateArrayA(n, m, min, max);
ShowArray(res1);
int[,] res2 = Create2ArrayB(a, b, min, max);
ShowArray(res2);
NewArrayC(res1, res2, n, m, a, b);
*/

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] Newarray(int n, int m, int z)
{
    int[,,] array = new int[n,m,z];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; i < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
                array[i,j,k] = Convert.ToInt32(Console.ReadLine());//new Random().Next(10,100);
    return array;
}

void ShowArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i,j,k] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] res = Newarray(n, m, z);
ShowArray(res);
*/
//от 10 до 99 элементов 89

// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n,m];
    int num = 0;
    for(int i = 0; i < array.GetLength(0);)
    {
        if(i == 0)
        {
            for(int j = 0; j < array.GetLength(1);j++)
            {
                num += 1;
                array[i,j] = num;
            } 
            i++;
        }
        if(i == array.GetLength(0) - 1)
        {
            for(int j = array.GetLength(1) - 1; j >= 0; j--)
            {
                num += 1;
                array[i,j] = num;
            }
            i++;
        }
        else
        {
            for(int j = 0; j < array.GetLength(1);j++)
            {
                if(j == array.GetLength(1) - 1)
                {
                    num += 1;
                    array[i,j] = num;
                        
                }
            }
            i++;
        }
    }
    return array;
}
    
    

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());


int[,] res = CreateArray(n, m);
ShowArray(res);
