//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя. 
Console.WriteLine("Введите пятизначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int fun1(int arg1)
{
    int num2 = arg1 - (arg1 / 10) * 10;
    return num2;
}
int fun2(int arg1)
{
    int num3 = arg1/ 10;
    return num3;
}
int num4 = fun1(num1);
int num5 = fun2(num1);
int num6 = fun1(num5);
int num7 = num4 * 10 + num6;
int num8 = num1 / 1000;
if (num8 == num7) Console.WriteLine("Число палинорм");
else Console.WriteLine("Число не палинорм");
