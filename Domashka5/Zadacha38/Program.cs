//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] mass(int n)
{
    double[] mass1 = new double[n];
    for (int i = 0; i < n; i++)
    {
        mass1[i] = new Random().NextDouble()*100;

    }
    return mass1;
}
int x = new Random().Next(1, 10);
double[] mass1 = mass(x);
for (int i = 0; i < x; i++)
    Console.Write($"{mass1[i]} ");
double max = mass1[0];
double min = mass1[1];
for(int i = 0; i < x; i++) 
{
    if (mass1[i] > max) max = mass1[i];
    if (mass1[i] < min) min = mass1[i];
}
double Raznost = max - min;
Console.WriteLine($"max-min={Raznost} ");
