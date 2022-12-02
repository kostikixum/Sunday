//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int s = 0;
if(N == 1)
{
    Console.Write("1");
}
else
{
    Console.Write("1");
    do
    {
        s = s + 2;
        Console.Write($",{s}");
    } while (s < N-1);
}