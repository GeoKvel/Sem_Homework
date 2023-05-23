// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Clear();
System.Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine()!);
if (x % 2 == 0)
    System.Console.WriteLine("Чётное ");
else
    System.Console.WriteLine("Нечётн ");