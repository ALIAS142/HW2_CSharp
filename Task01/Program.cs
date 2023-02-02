// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Enter three-digit number number:   ");
string strnumberA = Console.ReadLine();
int numberA = Convert.ToInt32(strnumberA);

int numberB = numberA/10;
int numberC = numberB%10;

Console.Write($"{numberC}");