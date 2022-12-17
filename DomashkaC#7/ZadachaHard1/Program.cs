//Задача HARD SORT необязательная. Считается за три обязательных
//Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры.
//Отсортировать элементы по возрастанию слева направо и сверху
Console.WriteLine("Размерность строк M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Размерность столбцов N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вывод массива [{m},{n}]");
double[,] mass = new double[n, m];//Создание и вывод масива в консоль с заполнением рандомными числами
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        mass[i, j] = random.Next(10);
        Console.Write("{0,4}", mass[i, j]);

    }
    Console.WriteLine();
}
int x = m * n;
double[] mass2 = new double[x];
int z=0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        mass2[z] = mass[i, j];
        z++;

    }
}//переводим двух мерный в двух мерный
double[] mass3(double[] array2)
{
    double temp;
    for (int i = 0; i < array2.Length - 1; i++)
    {
        for (int j = i + 1; j < array2.Length; j++)
        {
            if (array2[i] > array2[j])
            {
                temp = array2[i];
                array2[i] = array2[j];
                array2[j] = temp;
            }
        }
    }
    return array2;
}// метод сортировки масива от меьшего к большему
Console.WriteLine();
double[] d = new double[n];// возвращаем отсортировный масив 
d = mass3(mass2);
Console.WriteLine("Вывод отсортировоного масива");
double[,] mass4 = new double[n, m];
    int k=0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
         mass4[i, j]=d[k];
        k++;
        Console.Write("{0,4}", mass4[i, j]);
    }
    Console.WriteLine();
}//переводим одномерный в двух мерный масив и выводим его на экран.

