﻿// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int KollichBolshe(int size)
{
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if(num >= 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int res = KollichBolshe(size);
Console.Write($"Колличество чисел, которые больше нуля: {res}");
*/

// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void CommonPoint(int k1, int b1, int k2, int b2)
{
    double x, y;
    int x1, x2;
    if ((k1 == k2) && (b1 == b2))
        Console.Write("Прямые совпадают");
    else if (k1==k2)
        Console.Write("Прямые параллельны");
    else
    {
        // Почему-то через double x = (b2-b1)/(k1-k2) выводило 0?;
        x1 =(b2-b1);
        x2 = (k1-k2);
        x = x1/x2;
        y=k2*x + b2;
        Console.Write("x=" + x + "y=" + y);
    }
}

int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());

CommonPoint(k1, b1, k2, b2);

