//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1<8)
{
    if (num1 < 6)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else
{
    Console.WriteLine("Ошибка-число не обозначает день недели");
}
