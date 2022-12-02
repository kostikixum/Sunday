Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int kub(int arg1)
{
    int num2 = arg1 * arg1 * arg1;
    return num2;
}
int num3 = kub(num1);
int i = 1, num4;
Console.Write($"таблица кубов чисел до {num1} >>0");
do
{
    num4 = kub(i);
    i++;
    Console.Write($",{num4}");
} while (num4 < num3);
