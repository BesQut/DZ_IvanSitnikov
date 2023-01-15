// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}

Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int ShowNum(int num1, int num2)
{
    if(num1 <= num2)
    {
        return ShowNum(num1+1, num2) + num1; 
    }
    return 0;
}

void CourseNum(int num1, int num2)
{
    if(num1 < num2)
    {
        Console.Write(ShowNum(num1, num2));
    }
    else
    {
        Console.Write("Введенs не правильный порядок цифр");
    }
}

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2:");
int num2 = Convert.ToInt32(Console.ReadLine());
CourseNum(num1, num2);
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int ShowNum(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n > 0) && (m == 0)) return ShowNum(n - 1, 1);
    else return ShowNum(n - 1, ShowNum(n, m - 1));
}

Console.Write("Введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(ShowNum(n, m)); 
*/