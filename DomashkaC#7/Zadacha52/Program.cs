// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
double[,] mass = new double[3, 3];//Создание и вывод масива в консоль с заполнением рандомными числами
Random random = new Random();
double sr0 = 0, sr1 = 0, sr2 = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        mass[i, j] = random.Next(100);
        Console.Write("{0,4}", mass[i, j]);
    }
    Console.WriteLine();
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (i == 0) sr0 = (mass[i, j] + sr0) / 3;
        if (i == 1) sr1 = (mass[i, j] + sr1) / 3;
        if (i == 2) sr2 = (mass[i, j] + sr2) / 3;
    }
    
}
Console.WriteLine($"{sr0},{sr1},{sr2}");
