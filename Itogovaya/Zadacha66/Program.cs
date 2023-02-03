//Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
int min, max;
if (N < M)
{
    min = N;
    max = M;
}
else
{
    min = M;
    max = N;
}
int SummaN_M(int n, int m)
{
    if (n == (m + 1))
    {
        return 0;
    }
    return n + SummaN_M(n + 1, m);
}
Console.WriteLine($"сумма чисел от {min} до {max} равна {SummaN_M(min, max)}");