//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
Console.WriteLine("Введите число M не больше 3");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N не больше 5");
int N = Convert.ToInt32(Console.ReadLine());
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
Console.WriteLine($"Фугкция Акермана чисел A({M},{N}) равна {Akkerman(M, N)}");
