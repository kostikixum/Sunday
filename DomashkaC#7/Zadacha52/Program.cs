// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
double[,] mass = new double[3, 3];//Создание и вывод масива в консоль с заполнением рандомными числами
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        mass[i, j] = random.Next(100);
        Console.Write("{0,4}", mass[i, j]);
    }
    Console.WriteLine();
}
double[] SrSnStolb(double[,] array) // метод который находит min max и разницу между ними
{
    double sr0 = 0, sr1 = 0, sr2 = 0;
    for (int i = 0; i < 3; i++)
    {
        sr0 = (array[i, 0] + sr0);
        sr1 = (array[i, 1] + sr1);
        sr2 = (array[i, 2] + sr2);
    }
    sr0 = Math.Round((sr0 / 3), 1);
    sr1 = Math.Round((sr1 / 3), 1);
    sr2 = Math.Round((sr2 / 3), 1);
    double[] SrZn = new double[] { 0, 0, 0, };
    SrZn[0] = sr0;
    SrZn[1] = sr1;
    SrZn[2] = sr2;
    return SrZn;
}//метод нахождения средних значений столбцов
double[] SrZnM = new double[0];
SrZnM= SrSnStolb(mass);
Console.Write($" {SrZnM[0]}; {SrZnM[1]}; {SrZnM[2]};");
