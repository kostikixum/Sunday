// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
int[] mass(int n)// задаем масив тз трех значных чисел
{
    int[] mass1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        mass1[i] = new Random().Next(-99,99);
    }
    return mass1;
}
int x= new Random().Next(0,10);
int[] mass1 = mass(x);
for (int i = 0; i < x; i++)
    Console.Write($"{mass1[i]} ");
int num3 = 0;//хоть 0 и не делиться на 2 без остатка,он являеться четным числом.
for (int i = 1; i < x; i = i + 2)
{
     num3 = num3 + mass1[i];
}
Console.Write($"-->{num3}");
