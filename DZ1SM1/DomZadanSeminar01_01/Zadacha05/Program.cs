//Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет.
Console.WriteLine("Введите число N");
int num1 = Convert.ToInt32(Console.ReadLine());
string num2 = num1.ToString();// возвращаем переменную num1 в вид строки символов
int[] arrInt = new int[num2.Length]; // иницинируем масив в который помещаем num2
for (int n = 0; n < num2.Length; ++n) // вводим переменную n=0 ,если размер масива больше 0 то происходит приращение n
{
    arrInt[n] = int.Parse(num2[n] + "");
}

int s = (num2.Length);
if (s>2)
{
    Console.WriteLine(arrInt[2]);
}
else
{
   Console.WriteLine("Число меньше трехзначного");
}
