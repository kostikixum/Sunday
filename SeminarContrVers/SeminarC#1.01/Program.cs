internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ведите число дня недели");
        int Day = Convert.ToInt32(Console.ReadLine());
        if (Day == 1) Console.WriteLine("понедельник");
        if (Day == 2) Console.WriteLine("вторник");
        if (Day == 3) Console.WriteLine("среда");
        if (Day == 4) Console.WriteLine("четверг");
        if (Day == 5) Console.WriteLine("пятница");
        if (Day == 6) Console.WriteLine("суббота");
        if (Day == 7) Console.WriteLine("воскресенье");
        if (Day>7) Console.WriteLine("число введено не верно");
        if (Day <1) Console.WriteLine("число введено не верно");
    }
}