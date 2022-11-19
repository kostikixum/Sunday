//Напишите программу, которая на вход получает размерность массива. 
//Далее заполняет его случайными уникальными числами и выводит на экран.
//Далее производим сортировку массива от большего к меньшему и выводим на экран. 
//Далее придумываем алгоритм перемешивания списка на основе случайности 
// применяем этот алгоритм и выводим на экран результат.
// Встроенные методы работы со списками использовать нельзя.
Console.WriteLine("Введите размерность масива");
int n = Convert.ToInt32(Console.ReadLine());// задаем размер масива
int[] mass(int n)
{
    int[] mass1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        mass1[i] = new Random().Next(0, 101);
    }//заполняем массив числами от 0 до 100
    return mass1;
}// метод создания масива с рандомными числами 
int[] mass1 = mass(n);//возвращаем масив
Console.Write("массив---------------------------------->");
for (int i = 0; i < mass1.Length; i++)
{
    Console.Write($"{mass1[i]} ");
}
Console.WriteLine($"    ");
int[] mass3(int[] array2)
{
    int temp;
    for (int i = 0; i < array2.Length - 1; i++)
    {
        for (int j = i + 1; j < array2.Length; j++)
        {
            if (array2[i] < array2[j])
            {
                temp = array2[i];
                array2[i] = array2[j];
                array2[j] = temp;
            }
        }
    }
    return array2;
}// метод сортировки масива от большего к меньшему 
int[] d = new int[n];// возвращаем отсортировный масив 
d = mass3(mass1);
Console.Write("Вывод отсортированного массива---------->");
for (int i = 0; i < d.Length; i++)
{
    Console.Write($"{d[i]} ");
}
Console.WriteLine($"    ");
Console.Write("Вывод сорт. в случайном порядке массива->");
Random rand = new Random();//рандомная переменная 
for (int i = mass1.Length-1; i >= 0; i--)
{
    int j = rand.Next(i + 1);

    int temp = mass1[j];
    mass1[j] = mass1[i];
    mass1[i] = temp;
    Console.Write($"{mass1[i]} ");
}//Сортировка масива в рандомном порядке



