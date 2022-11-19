// чиссла по спирали
Console.WriteLine("Введите целое число");
int q = Convert.ToInt32(Console.ReadLine());
if (q <= 0) Console.WriteLine("Ошибка введите целое число");
int n = q;//размер матрицы
int m = n;
int l = n;
int t = 2;
int k = 0;
int x = 0;
int y = 0;
int[,] arr = new int[n, m];
void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            int o = array[a, b];
            if (o < 10)
            {
                Console.Write($"0{array[a, b]} ");
            }
            else
            {
                Console.Write(array[a, b] + " ");
            };

        }
        Console.WriteLine();
    }
}//метод вывода масива
arr[0, 0] = 1;
while (t <= (q * q))
{
    while (y < n-1 )
    {
       
        y = y + 1;
        arr[x, y] = t;
        t = t + 1;
    };//движение с лева на право
    while (x < n - 1)
    {
       
        x = x + 1;
        arr[x, y] = t;
        t = t + 1;
    };//движение в низ
    while (y > k)
    {
       
        y = y - 1;
        arr[x, y] = t;
        t = t + 1;
    };//движение на лево
    k = k + 1; n = n - 1;
    while (x > k)
    {
       
        x = x - 1;
        arr[x, y] = t;
        t = t + 1;
    };//движение вверх
};//движение по спирали
Console.WriteLine("Спиральная матрица");
PrintArray(arr);