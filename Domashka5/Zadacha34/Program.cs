// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] mass(int n)// задаем масив тз трех значных чисел
{
    int[] mass1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        mass1[i] = new Random().Next(100,1000);
    }
    return mass1;
}
int[] mass1 = mass(4);
for (int i = 0; i < 4; i++)
    Console.Write($"{mass1[i]} ");
int schet0 = 0;
for (int i = 0; i < 4; i++)
{
    if (mass1[i] %2== 0) schet0++;
} //считаем четное 
Console.Write($"-->{schet0}");
