﻿// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

Console.WriteLine("Введите число");int num = Convert.ToInt32(Console.ReadLine());int X = Factorial(num);Console.WriteLine($"Произведение чисел от 1 до N равно = {X}");int Factorial(int num){    int fact = 1;    for (int i = 1; i <= num; i++)        fact = fact * i;    return fact;}
