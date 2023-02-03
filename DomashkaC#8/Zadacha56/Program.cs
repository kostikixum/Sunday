// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
int[,] GenerateArray(int t, int i)
{
    int[,] table = new int[t, i];
    Random random = new Random();
    for (int a = 0; a < t; a++)
    {
        for (int b = 0; b < i; b++)
        {
            table[a, b] = random.Next(0, 9);
        }
    }
    return table;
}//метод генерации рандомного масива
void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }
}//метод вывода масива
Console.WriteLine("Введите количество строк двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
int colCount = m;
int rowCount = n;
int[] Sum = new int[m];
int sum = 0;
int min = Sum[0];
int minIndx = 0;
int[,] arr = GenerateArray(rowCount, colCount);
Console.WriteLine("Исходный массив");
PrintArray(arr);
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];

    }
    Sum[i] = sum;
    sum = 0;
}//Сумма по строкам
Console.WriteLine($"{Sum[0]},{Sum[1]},{Sum[2]},{Sum[3]}");
for (int i = 0; i < n-1; i++)
{
    if (Sum[i] <= min)
    {
       min = Sum[i];
        minIndx = i;
    }
    else min = 35;
}// Нахождение минимума
Console.WriteLine($"Минимальная сумма находиться в {minIndx} строке");
