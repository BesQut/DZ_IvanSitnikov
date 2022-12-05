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
    int n = 10;
    if(num >= 1000)
    {
        while(num >= 1000)
        { 
            num = num / n; 
        }
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

