// Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
Console.WriteLine("Введите длину стороны A");int a = Convert.ToInt32(Console.ReadLine());Console.WriteLine("Введите длину стороны B");int b = Convert.ToInt32(Console.ReadLine());Console.WriteLine("Введите длину стороны C");int c = Convert.ToInt32(Console.ReadLine());if (a < b + c && b < a + c && c < a + b)
    Console.WriteLine("такой треугольник может существовать");else
    Console.WriteLine("такой треугольник не может существовать");
