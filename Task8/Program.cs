﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
System.Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
    {
        System.Console.Write(i + " ");
        i++;
    }
    else i++;
}