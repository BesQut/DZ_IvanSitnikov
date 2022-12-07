// Задача 1. Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом. Доделать!!!!
/*
bool Palindrom(int num)
{
    int n = 10;
    int i = 10;
    while(num / n != 0)
    {
        int res = num / n;
        int res2 = num % i;
        if(res == res2)
        {
            n = n*10;
            i = i*10;
            return true;
        }
        else
        {
            return false;
        }
    }
}

int num = Convert.ToInt32(Console.ReadLine());
int res3 = Palindrom(num);
if(Palindrom == true)
{
    Console.Write($"Число: {num} палиндром");
}
else
{
    Console.Write($"Число: {num} не палиндром");
}
*/



// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Kord(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double C = Math.Sqrt(Math.Pow(xA-xB,2) + Math.Pow(yA-yB,2) + Math.Pow(zA-zB,2));
    double res = Math.Round(C,2);
    return res;
}

Console.WriteLine("Введите координаты для точек");
Console.Write("xA= ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("yA= "); 
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("zA= ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("xB= ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("yB= ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("zB= ");
double zB = Convert.ToDouble(Console.ReadLine());

double res = Kord(xA, yA, zA, xB, yB, zB);
Console.Write(res);
*/
// ЗАдача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void NumQuad(int n)
{
    int i = 1;
    while(i <= n)
    {
        double res = Math.Pow(i,3);
        Console.Write(res + " ");
        i++;
    }

}

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

NumQuad(n);
*/



