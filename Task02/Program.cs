//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter number:   ");
string strnumberA = Console.ReadLine();
int numberA = Convert.ToInt32(strnumberA);

if (numberA > 9 & numberA < 99)
{
    Console.WriteLine("number is absent");
}

else
if (numberA > 99 & numberA < 999)
{
    int result = numberA%10;
    Console.WriteLine(result);
}

