Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int lengt(int arg1)
{
    int num2, num3, num4 = 0;
    do
    {
        num2 = arg1 / 10;
        num3 = arg1 - (num2 * 10);
        num4 = num4 + 1;
        arg1 = num2;
    } while (num2 > 0);
    return num4;

};
int num5 = lengt(num1);// получение длинны числа
int poslCF(int arg1)
{
    int num1 = arg1 / 10;
    int num2 = arg1 - (num1 * 10);
    return num2;
};//получение последнего числа
int num6 = poslCF(num1);
int[] massiv = new int[num5];//преобразование числа в масив
int i = 0;
do
{
    int num11 = num1 / 10;
    int num12 = num1 - (num11 * 10);
    massiv[i] = num12;
    i++;
    num1 = num11;
} while (i < num5);
i = 0;
/*do
{
    Console.Write(massiv[i]);
    i++;
} while (i < num5);*/ //вывод масива полученого из числа
int num14 = num5 / 2;
int[] copy = new int[massiv.Length];//создание копии масива
massiv.CopyTo(copy, 0);
//Console.WriteLine(String.Join(", ", copy)); вывести данные масива через запятую.
int serM = num5 / 2;//середина масива ,две половины будут сравниваться 
int max = num5-1;// так как длинна числа отличаеться от длины масива отнимаем 1
int p = 0;// счетчик совпадений
for (int c = 0; c < serM; c++)
{
    for (int j=max; j >= serM; j--)
    {
        if (massiv[c] == copy[j])
        {
            p++;
        }
    }
};// сравнение половины первого масива от 0 до середины и половины второго масива от последнего до середины
if (p == serM)
{
    Console.WriteLine("число полинорм");
}// если количество совпадений равняеться середине масива то число полинорм
else
{
    Console.WriteLine("число не полинорм");
}