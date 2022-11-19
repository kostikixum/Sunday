// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456-> 3//78-> 2//89126-> 5
int lengt(int arg1)
{
    int num2,num4 = 0;
    do
    {
        num2 = arg1 / 10;
        num4 = num4 + 1;
        arg1 = num2;
    } while (num2 > 0);
    return num4;

};

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"количество цифр в числе {num} равна {lengt(num)}");