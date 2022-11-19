// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
int SumNambers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++) sum += i;
    return sum;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма всех числе от 1 до {num} равна {SumNambers(num)}");