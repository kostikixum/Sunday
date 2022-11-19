void PrintArray(string[] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {


        Console.Write(array[a] + " ");
    }
    Console.WriteLine();
}//метод вывода масива
string[] array = { "О", "да", "это",
     "работает", "не", "гуд", };
Console.WriteLine("Введите индекс");
int index = Convert.ToInt32(Console.ReadLine());
string[] newArray = new string[array.Length - 1];//образуем новый масив меньшего размера
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

