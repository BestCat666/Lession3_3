﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

//Задача 22: Напишите программу, которая принимает на 
//вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i = 1;
while (i <= N)
{
    Console.WriteLine($"{i} -> {Math.Pow(i, 2)}");
    i++;
}


Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    if (i != N) Console.Write($"{i*i}, ");
    else Console.Write($"{i*i}");
}

