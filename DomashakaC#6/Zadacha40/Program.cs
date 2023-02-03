//задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа.
// Определить , является ли это сторонами треугольника.
// Если да, то вывести всю информацию по нему - площадь,//
// периметр, значения углов треугольника в градусах,
// является ли он прямоугольным, равнобедренным, равносторонним.
Console.WriteLine("Введите сторону a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите сторону b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите сторону c");
double c = Convert.ToDouble(Console.ReadLine());
// расчеты периметра,площади,углов 
double angleA, angleB, angleC;
double p = (a + b + c) / 2;
double P = (a + b + c);//периметр
double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));//площадь
angleA = Math.Asin((2 * S) / (a * b)) * (180 / Math.PI);//превод в радианы и расчет углов
angleB = Math.Asin((2 * S) / (b * c)) * (180 / Math.PI);
angleC = 180 - angleA - angleB;
double AC = Math.Round(angleA);//округление
double AB = Math.Round(angleB);
double CB = Math.Round(angleC);
double Sabc = Math.Round(S);
double Pabc = Math.Round(P);
double max = a, min1 = b, min2 = c;
if (b >= max)
{
    max = b;
    min1 = a;
}// нахождение гипотенузы и катедов
if (c >= max)
{
    max = c;
    min2 = b;
}
if (max < min1 + min2)// сравнение суммы катетов с гипотенузой
{
    Console.WriteLine($"Треугольник со сторонами a={a} b={b} c={c} существует");
    Console.Write($" c углами <AB={AB}гр <AC={AC}гр <CB={CB}гр Площадью = {Sabc} Периметром={Pabc} ");
}//определение существует ли треугольник 
else
{
    Console.WriteLine($"Треугольник со сторонами a={a} b={b} c={c} не существует");
}
// определяем тип треугольника
if (a == b && b == c && a == c)
{
    Console.Write($"и он равносторонний");
}
else if (a == b || b == c || a == c)
{
    Console.Write($"и он равнобедренный");
}
if(AB==90||AC==90||CB==90) Console.Write($"и он прямоуголный");