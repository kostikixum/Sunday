//  Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
int[] mass(int n)
{
    int[] mass1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"введите число индекса {i}");
        mass1[i] = Convert.ToInt32(Console.ReadLine());
    }
    return mass1;
}
//Console.WriteLine(String.Join(", ", mass(8)));// вывод масива через строку
int[] mass1 = mass(8);
for (int i = 0; i < 8; i++)
 Console.Write($"{mass1[i]} ");//вывод масива через цикл
