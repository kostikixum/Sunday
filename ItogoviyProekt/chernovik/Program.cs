void PrintArrayString(string[] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {


        Console.Write(array[a] + " ");
    }
    Console.WriteLine();
}//метод вывода масива строк
void PrintArray(int[] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {


        Console.Write(array[a] + " ");
    }
    Console.WriteLine();
}//метод вывода масива
string[] array = {"ура","это","нееее",
     "не работает","run","раб","ота","ет"};
int m = 3;//максимальный размер строки
int z = 0;//количество слов котрое больше m
int y = 0;//index нового масива
int[] index = new int[array.Length];
for (int i = 0; i < array.Length-1; i++)
{
    if (array[i].Length > m)
    {
         index[i] = 1; z++;
    }
    else
    {
         index[i] = 0;
    }
}// создаем масив где 1 отмечаны индексы слов больше 3
string[] newArray = new string[array.Length - z];//образуем новый масив 
for (int i = 0; i < index.Length; i++)
{
    if (index[i] == 0)
    {
        newArray[y] = array[i];
        y++;
    }
}//заполняем новый масив словами котрые меньше или равны m;
PrintArrayString(newArray);