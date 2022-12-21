//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных) двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[] RandomIncluz(int[] array)
{
    int t = array.GetLength(0);
    int[] table = new int[t];
    Random random = new Random();
    table[0] = random.Next(10, 99);
    for (int a = 1; a < t; a++)
    {
         table[a] = random.Next(10,99);
        for (int b = 0; b < a; b++)
        {
            if (table[b] == table[b + 1])
                table[b] = random.Next(10, 99);
        }
    }
    return table;
}//генерация одномерного маисва с уникальными рандомными числами
void PrintArray3(int[,,] array) //вывод трехмерного массива
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int k = 0; k < array.GetLength(2); ++k)
            {
                Console.Write($"{array[a, b, k ]} ({a},{b},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}//метод вывода масива
int[] arr1 = new int[8];
int[,,] arr3 = new int[2, 2, 2];
int[] arr2 = RandomIncluz(arr1);
int t = 0;
Console.WriteLine();
for (int a = 0; a < arr3.GetLength(0); a++)
{
    for (int b = 0; b < arr3.GetLength(1); b++)
    {
        for (int k = 0; k < arr3.GetLength(2); ++k)
        {
            arr3[a, b, k] = arr2[t];
            t++;
        }
    }
}// заполняем масив из уникального набора чисел
PrintArray3(arr3);
       
            