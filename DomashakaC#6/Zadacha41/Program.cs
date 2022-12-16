// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количество цифр");
int M = Convert.ToInt32(Console.ReadLine());
double[] array = new double[M];
Console.Write("введите числа через проблел: ");
double[] numbers = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToArray();
for (int i = 0; i < M; i++)
    array[i] = numbers[i];
int Col = 0;

Console.Write("Вывод: ");

for (int i = 0; i < M; i++)
{
    Console.Write($" {array[i]}, ");
}
for(int i = 0; i < M; i++)
{
    if (array[i] > 0) Col++;
}
Console.Write($"----> {Col}, ");