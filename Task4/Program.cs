// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
System.Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите число c ");
int c = int.Parse(Console.ReadLine()!);

int max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;

System.Console.WriteLine(max);




// {
//     max = b;
//     else if (c > max)
//         max = c;
//     if (c>max)
//         max = c;    
// }
// System.Console.WriteLine(max);