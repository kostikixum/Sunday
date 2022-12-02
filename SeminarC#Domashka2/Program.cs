// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
int Indx (int arg1)
{
    int num2, num3, num4 = 0;
    do
    {
        num2 = arg1 / 10;
        num3 = arg1 - (num2 * 10);
        num4 = num4 + 1;
        arg1 = num2; 
    } while (num2 >0);
 return num4;
}
int Z(int arg1,int arg2)
{
    int num8, num6, num7 = 0;
    do
    {
        num8 = num6 / 10;
        num9 = num6 - (num8 * 10);
        num7 = num7 + 1;
        num6 = num8;
    } while (num7 < arg2);
   return num9
}

Console.WriteLine("Введите целое число");
int num8 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс числа");
int num9 = Convert.ToInt32(Console.ReadLine());
int index = Indx(num8,num9);
Console.WriteLine(index);


