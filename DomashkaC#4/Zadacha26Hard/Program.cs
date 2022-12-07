// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе 
Console.WriteLine("Введите любое число");
double num1 = Convert.ToDouble(Console.ReadLine());
double num4 = num1;
double BezTochki(double arg1)
{
    double num3 = num1;
    do
    {
        num1 = num1 * 10;
        int num2 = (int)num1;
        num3 = (double)num2;
    } while (num1 != num3) ;
    return num3;
}// приводим число из числа с остатком в число без например 1,45 станет 145
double num2 = BezTochki(num1);
int num10 = (int)num4;//если число начинаеться на 0 при раачете будет ошибка для этого эта проверка
num10 = num10 * 10;//удаление ошибки целого числа
int num9 = (int)num2;// преобразование в int так как если делать расчет в double ввывод будет равняться числу на 30 едениц больше
if (num9 == num10) num9 = num9 /10;// если вводится целое число то будет лишний 0,для этго его убираем
int lengt(int arg1)
{
    int num7, num8 = 0;
    do
    {
        num7 = arg1 / 10;
        num8 = num8 + 1;
        arg1 = num7;
    } while (num7 > 0);
    return num8;

};// вычисляем длинну числа через цикл деления
int num11 = lengt(num9);
if (num10 == 0) num11 = num11 + 1;//если число начинаеться на 0 при раачете будет ошибка для этого эта проверка которая добавляет 1
Console.WriteLine($"количество цифр в числе {num4} равна {num11}");