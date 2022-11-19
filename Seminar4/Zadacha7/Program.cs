// See Задача 30: Напишите программу, которая выводит массив из 8 элементов
// заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

Console.WriteLine("Введите размерность масива");
int n = Convert.ToInt32(Console.ReadLine());
int[] mass(int n) 
{
    int[] mass1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        mass1[i] = new Random().Next(0, 2);
    }//заполняем массив числами от 1 до 0
    return mass1;
}

 Console.WriteLine(String.Join(", ", mass(n)));