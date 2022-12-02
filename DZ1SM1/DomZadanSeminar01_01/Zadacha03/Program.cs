//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2==0)
{
    Console.WriteLine($"{num1} четное");
}
else
{
    Console.WriteLine($"{num1} нечетное");
}
