Console.WriteLine("Введите размерность пространства");
int n = Convert.ToInt32(Console.ReadLine());
double[] cord = new double[n];// масив в котором бкдут храниться координаты
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите {0}-вые координаты точки А", i + 1);
    cord[i] = Convert.ToInt32(Console.ReadLine());
}//вносим в масив размера A кординаты точек ,количество ограничено введеной размерностью
Console.WriteLine(String.Join(", ", cord));
double[] cord2 = new double[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите {0}-вые координаты точки B", i + 1);
    cord2[i] = Convert.ToInt32(Console.ReadLine());
}//вносим в масив размера B кординаты точек
Console.WriteLine(String.Join(", ", cord2));
double[] kvadrat = new double[n];
for (int i = 0; i < n; i++)
{
    double x = cord[i] - cord2[i];
    kvadrat[i] = Math.Pow(x,2);
}
//Console.WriteLine(String.Join(", ", kvadrat));
double sum = kvadrat.Sum();//вычисляем суммы всех элементов масива
double result = Math.Sqrt(sum);//вычисляем квадратный корень из суммы
double rasto = Math.Round(result, 2);//сводим результат до двух знаков после запятой
Console.WriteLine(rasto);