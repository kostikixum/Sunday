// Задача 26: Напишите программу, которая принимает на вход
//  число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите   число");int num = Convert.ToInt32(Console.ReadLine());int sum = count_num(num);Console.WriteLine($"В числе {num} {sum} знаков");int count_num(int num){    if (num < 0)        num = num * (-1);    int temp = 0;    if (num < 10)    {        temp = 1;    }    else    {        double baseten = Math.Log10(num);        temp = Convert.ToInt32(Math.Truncate(baseten));        temp = temp + 1;    }    return temp;}
