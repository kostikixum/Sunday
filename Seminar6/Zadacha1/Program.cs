Console.WriteLine("Введите размерность масива");
int n = Convert.ToInt32(Console.ReadLine());// задаем размер масива
void mass(int n)
{
    int[] mass1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        mass1[i] = new Random().Next(0, 101);
    }//заполняем массив числами от 0 до 100
}// метод создания масива с рандомными числами 
int mass1 = mass(n);//возвращаем масив
Console.Write("массив---------------------------------->");
for (int i = 0; i < mass1.Length; i++)
{
    Console.Write($"{mass1[i]} ");
}