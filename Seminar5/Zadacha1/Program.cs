﻿//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве[3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
    array[i] = new Random().Next(-9, 10);

int sum_p = 0;
int sum_n = 0;
//цикл проходящийся по всем значениям array, то есть el принимает по очереди все значеиня массива
//применяется только для просмотра
foreach (int el in array)
{
    Console.Write($"{el} ");
    if (el > 0) sum_p += el;
    else sum_n += el;
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел равна {sum_p}");
Console.WriteLine($"Сумма отрицательных чисел равна {sum_n}");
