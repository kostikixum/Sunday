// Задача 26: Напишите программу, которая принимает на вход
//  число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int count_num(int arg1)// решение через цикл wail 
{
    int count = 0;
    while(arg1 != 0)
    {
        arg1 = arg1 / 10;
        count++;
    }
    return count;
}
Console.WriteLine("Введите   число");int num = Convert.ToInt32(Console.ReadLine());int sum = count_num(num);Console.WriteLine($"В числе {num} {sum} знаков");