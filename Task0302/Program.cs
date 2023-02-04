// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Второй вариант:


System.Console.WriteLine("Which is a day of week today? Enter a number of week");
int DayOfWeek1;

if (! int.TryParse(Console.ReadLine(), out DayOfWeek1))
{
  System.Console.WriteLine("Which is a day of week today? Enter a number of week");
  return;
}

if (DayOfWeek1 < 0 || DayOfWeek1 > 7)
{
  System.Console.WriteLine("This day does not exist");
  return;
}

if (DayOfWeek1 == 6 || DayOfWeek1 == 7)
System.Console.WriteLine("Its a day off");
else
System.Console.WriteLine("Its a working day");
