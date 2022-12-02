// Напишите программу, которая выводит на экран числа от 1 до 100.
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz,
// а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz.
// Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.
int numberA = new Random().Next(1, 101);// случайное число от 1 до 100(max-1)
Console.WriteLine(numberA);
int kratnoe(int arg1,int arg2)
{
    int num2=numberA;
    while (num2 > 0)
    {
        num2 = arg1 - arg2;
        arg1 = num2;
    };
    return num2;
}
int kratnoe3 = kratnoe(numberA, 3);
int kratnoe5 = kratnoe(numberA, 5);
int kratnoe15 = kratnoe(numberA, 15);
 if (kratnoe15 == 0) Console.WriteLine("FizzBuzz");
 else if (kratnoe3 == 0) Console.WriteLine("Fizz");
 else if (kratnoe5 == 0) Console.WriteLine("Buzz");
 else Console.WriteLine("число не кратно 3,5,15");



