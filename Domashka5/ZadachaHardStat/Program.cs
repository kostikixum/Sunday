// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс
// минимальный элемент и его индекс, среднее арифметическое всех элементов. 
//Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
//Найти медианное значение первоначалального массива 
// возможно придется кое-что для этого дополнительно выполнить.
int[] mass(int n)// 
{
    int[] mass1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        mass1[i] = new Random().Next(0, 101);

    }
    return mass1;
}// Задаем рандомный масив
int x = new Random().Next(1, 10);
int[] mass1 = mass(x);
for (int i = 0; i < mass1.Length; i++)
    Console.Write($"{mass1[i]} ");
int[] mass2(int[] array) 
{
    int Summ = 0;
    int InMax = 0;
    int InMin = 0;
    int max = array[0];
    int min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        { 
          min = array[i];
          InMin = i;
        }
        if (array[i] > max)
        {
            max = array[i];
            InMax = i;
        }
        Summ = Summ + array[i];
    }
    int[] raznost = new int[] { 0, 0, 0, 0, 0, 0 };
    int r = max - min;
    raznost[0] = min;// если на входе метода аргумент масив,то и вернуть можно только масив.
    raznost[1] = max;// таким образом можно выести несколько аргуентов метода
    raznost[2] = InMax;
    raznost[3] = InMin;
    raznost[4] = Summ;
    raznost[5] = 0;
    return raznost;
}// метод который находит min max и их идексы сумму всех членов и выводит через масив
int[] b = new int[0];
b = mass2(mass1);
int[] mass3(int[] array2)
{
    int temp;
    for (int i = 0; i < array2.Length - 1; i++)
    {
        for (int j = i + 1; j < array2.Length; j++)
        {
            if (array2[i] > array2[j])
            {
                temp = array2[i];
                array2[i] = array2[j];
                array2[j] = temp;
            }
        }
    }
     return array2;
}// метод сортировки масива от меньшего к большему 
int[] d = new int[x];
d = mass3(mass1);
int l= d.Length;
int Mediana;
if (l % 2 != 0) 
{
    int m = l / 2;
    Mediana = d[m];
}
else 
{
    int m = l / 2;
    Mediana = (d[m] + d[m - 1])/2;
}
Console.WriteLine($"    ");
Console.WriteLine($"min={b[0]},max={b[1]} ,Индекс Max {b[2]} ,индекс min {b[3]}, Сумма всех членов {b[4]} ");
Console.WriteLine($"    ");
Console.WriteLine($"Медиан массива равен ={Mediana}");