// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
System.Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine()!);
int Max = a;
if (b > Max)
    Max = b;
System.Console.WriteLine($"Максимальное число = {Max}");