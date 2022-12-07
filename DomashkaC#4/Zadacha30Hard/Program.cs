//  Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.. 
//Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран
// иначе вывести False.
int[] mass(int n)
{
    int[] mass1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        mass1[i] = new Random().Next(0, 2);
    }
    return mass1;
}
int[] mass1 = mass(8);
for (int i = 0; i < 8; i++)
    Console.Write($"{mass1[i]} ");
int schet0 = 0, schet1 = 0;
for (int i = 0; i < 8; i++)
{
    if (mass1[i] == 1)  schet1++;
    if (mass1[i] == 0)  schet0++;
} //считаем 0 и 1
if (schet0 > schet1) Console.Write("False");
else if (schet0 < schet1) Console.Write("True");
else Console.Write("Число 0 и 1 одинаково");

