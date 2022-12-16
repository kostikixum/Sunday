// задача 1 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n 
//(размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. 
//Найти минимальное число и его индекс, найти максимальное число и его индекс.
// Вывести эту информацию на экран.
Console.WriteLine("Размерность строк M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Размерность столбцов N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вывод массива [{m},{n}]");
Console.WriteLine("");
int[,] mass = new int[m, n];

Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mass[i, j] = random.Next(100);
        Console.Write("{0,4}", mass[i, j]);
    }
    Console.WriteLine();
}//Создание и вывод масива в консоль с заполнением рандомными числами
int Max = mass[0, 0], Min = mass[0, 0], MinIndexN = 0, MaxIndexN = 0, MinIndexM = 0, MaxIndexM = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mass[i, j] > Max) { Max = mass[i, j]; MaxIndexM = i; MaxIndexN = j; }
        if (mass[i, j] < Min) { Min = mass[i, j]; MinIndexM = i; MinIndexN = j; }
    }

}//Нахождение max min и их индексов
Console.WriteLine($"Max= {Max} с индексом[{MaxIndexM},{MaxIndexN}] Min= {Min} c индексом [{MinIndexM},{MinIndexN}]");