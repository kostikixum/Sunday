// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Stepen(int arg1,int arg2)
{
    int num1 = 1;
    for (int i = 0; i < arg2; i++)
        num1 = num1 * arg1;
    return num1;
}
Console.WriteLine("Введите число");
int chislo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int step = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"число {chislo} в степени {step} равно {Stepen(chislo,step)}");
