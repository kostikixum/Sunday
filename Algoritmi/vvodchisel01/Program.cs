// вводить цисла через ентер пока не введен пробел
int n = 10;
int[] mas = new int[n];
int i = 0;
string test;
int count = 0;
Console.WriteLine("Введите любое число");
do
{
    test = Console.ReadLine();
    if (test == " ") break;
    mas[i] = Convert.ToInt32(test);
    ++i; ++count;
} while (true);


Console.WriteLine("Vivod: ");
for (int j = 0; j < count; j++)
{
    Console.Write("{0} ", mas[j]);
}
Console.ReadLine();
