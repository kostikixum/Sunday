﻿// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
// 
//Чи́сла Фибона́ччи (вариант написания — Фибона́чи) — элементы числовой последовательности. 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597,
Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 1;
int count = 0;
Console.Write($"0, ");
for (int i = 2; i <= N; i++)
{
    count = num1 + num2;
    num2 = num1;
    num1 = count;
    Console.Write($"{count}, ");
}
