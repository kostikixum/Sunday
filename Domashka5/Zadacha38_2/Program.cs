//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] a = new double[] { 8.2, 2.3, 0.2, 2.4, 2.4, 2.4, 3, };
double[] mass(double []array) // метод который находит min max и разницу между ними
{
    double max = array[0];
    double min = array[1];
    for (int i = 0; i < 6; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double[] raznost = new double[] {0,0,0,};
    double r = max - min;
    raznost[0] = r;// если на входе метода аргумент масив,то и вернуть можно только масив.
    raznost[1] = max;// таким образом можно выести несколько аргуентов метода
    raznost[2] = min;
    return raznost;
}
double[] b = new double[0];
 b = mass(a);
Console.Write($"max({b[1]})-min({b[2]})={b[0]}");
