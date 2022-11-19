//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
int[,] ArrMultipi(int[,] A, int[,] B)
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    int Mult = 0;
    int a1 = 0, a2 = 0, b1 = 0, b2 = 0;

    if (A.GetLength(1) == B.GetLength(0))
    {

        for (a1 = 0; a1 < A.GetLength(0); a1++)
        {
            for (b2 = 0; b2 < B.GetLength(1); b2++)
            {
                for (a2 = 0, b1 = 0, Mult = 0; a2 < A.GetLength(1); a2++, b1++)
                {
                    Mult += A[a1, a2] * B[b1, b2];
                }

                C[a1, b2] = Mult;
            }
        }
    }

    return C;
}// метод умножения матриц паралельным спосо
Console.WriteLine("Введите размер матриц");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
int colCount = m;
int rowCount = n;
int[,] arr = GenerateArray(rowCount, colCount);
int[,] arr2 = GenerateArray(rowCount, colCount);
Console.WriteLine("Первая матрица");
PrintArray(arr);
Console.WriteLine("Вторая матрица");
PrintArray(arr2);
int[,] arr3 = ArrMultipi(arr, arr2);
Console.WriteLine("Произведение двух матриц");
PrintArray(arr3);