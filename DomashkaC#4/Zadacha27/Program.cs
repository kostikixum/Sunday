// See Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Через строку решать нельзя.
int SummaChisel(int arg1)
{
    int num2, num3, num5=0;
    do
    {
        num2 = arg1 / 10;
        num3 = arg1 - (num2 * 10);
        num5 = num5 + num3;
        arg1 = num2;
    } while (num2 > 0);
    return num5;

};
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма все чисел в {num}  равно {SummaChisel(num)}");