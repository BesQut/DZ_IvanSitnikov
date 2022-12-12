// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Quad(int a, int b)
{
    int n = a;
    for(int i = 1; i < b; i++)
    {
        a = a * n;
    }
    return a;
}

Console.Write("Число, которое будут возводить в квадрат: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = Quad(a, b);
Console.Write(res);
*/
// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Summa(int num)
{
    int n = 10;
    int count = 0, sum = 0;
    while(num/n != 0)
    {
        n = n * 10;
        count++;
    }
    int res = num;
    int res2;
    for(int i = 0; i <= count; i++)
    {
        res2 = res % 10;
        sum = sum + res2;
        res = res / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res3 = Summa(num);
Console.Write($"Сумма цифр в числе: {res3}");
*/
// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] Elements(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] =  Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] res = Elements(size);
ShowArray(res);
*/