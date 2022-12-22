//Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
string Natur(int n)
{
    if (n == 1)
    {
        return "1";
    }
    return Natur(n - 1) + " " + n;
}
Console.WriteLine($"{Natur(N)}"); ; 
