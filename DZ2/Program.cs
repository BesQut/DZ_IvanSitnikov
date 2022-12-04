// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNum(int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    
    return num2;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = SecondNum(num);

Console.Write($"Изначальное число: {num}, второе число: {res}");
*/
// Можно сделать через рандомное число, не вводя его, просто добавить после метода.
/*
int num = new Random().Next(100, 1000);
int res = SecondNum(num);

Console.WriteLine($"Изначальное число: {num}, второе число: {res}");
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
bool ThirdNum(int num)
{
    while(num / 100 != 0)
    {
        return true;
    }
    return false;
}

int Num(int num)
{
    if(num / 10000 != 0)
    {
        num = num / 100;
    }
    else if(num / 1000 != 0)
    
    {
        num = num / 10;
    }
    else if(num / 100 != 0)
    {
        return num;
    }
    return num;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(ThirdNum(num) == true)
{
    int num1 = Num(num);
    int res = num1 % 10;
    Console.Write($"Изначальное число: {num}, третье число: {res}");
}
else
{
    Console.Write("Нет третьего числа");
}
*/

// Для себя. Поробывал 2 задачу с помощью массивов, получилось только до числа 1234567
/*
bool ThirdNum(int num)
{
    while(num / 100 != 0)
    {
        return true;
    }
    return false;
}

int Num(int num)
{
    int num1 = num;
    int[] array = {10, 100, 1000, 10000, 100000, 1000000};
    if(num1 / 1000 != 0)
    {
        int num2;
        int i = 0;
        int n = 2;
        if(num > 100000)
        {
            n = 4;
        }
        while(n > i)
        {

            if(num1 / array[n+1] != 0)
            {
                Console.WriteLine(n);
                num2 = num1 / array[n-1];
                return num2;
            }
            else
            {
                num1 = num1;
            }
            n--;
            
        }
    }
    else
    {
        num1 = num1;
    }
    return num1;
}

int num3;
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(ThirdNum(num) == true)
{
    num3 = Num(num);
    int res = num3 % 10;
    Console.Write($"Изначальное число: {num}, третье число: {res}");
}
else
{
    Console.Write("Нет третьего числа");
}
*/

// задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Num(int num)
{
    if(num == 7 || num == 6)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите число дня: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = Num(num);

Console.Write($"Является ли этот день выходным: {res}");
*/

