//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Размерность строк M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Размерность столбцов N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вывод массива [{m},{n}]");
double[,] mass = new double[m, n];
Random random1 = new Random();
Random random2 = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mass[i, j] = random1.NextDouble() * 100 * (random2.Next(-1,2));
        Console.Write("{0,8:F2}", mass[i, j]);
    }
    Console.WriteLine();
}//Создание и вывод масива в консоль с заполнением рандомными числами