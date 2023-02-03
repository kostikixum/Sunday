// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
double[,] mass = new double[3, 3];//Создание и вывод масива в консоль с заполнением рандомными числами
Random random = new Random();
int str, stolb, zero=0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        mass[i, j] = random.Next(100);
        Console.Write("{0,4}", mass[i, j]);

    }
    Console.WriteLine();
}
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());//ищем число в масиве
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
       
        if (mass[i, j] == num1)
        {
            str = i;
            stolb = j;
            Console.Write($"в масивве число занимает положение [{i} {j}]");
        }
        else
        {
            zero++;
        }
        

    }
}
if (zero==9) Console.Write($"в масивве такого числа нет");//если совпадений не было ни разу значит числа нет

