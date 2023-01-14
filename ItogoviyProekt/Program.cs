void PrintArray(int[] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {


        Console.Write(array[a] + " ");
    }
    Console.WriteLine();
}//метод вывода масива
int m = 3;
string[] array = { "О", "да", "это",
     "работает", "не", "гуд", };
int index;
if (!int.TryParse(Console.ReadLine(), out index))
{
    Console.WriteLine("Некорректный индекс");
    return;
}

if (index < 0 || index >= array.Length)
{
    Console.WriteLine("Индекс за пределами массива");
    return;
}
int[] newArray = new string[array.Length - 1];
for (int i = 0; i < array.Length; i++)
{
    if (i < index)
    {
        newArray[i] = array[i];
    }
    else if (i > index)
    {
        newArray[i - 1] = array[i];
    }
}
PrintArray(newArray);