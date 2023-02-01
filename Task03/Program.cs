// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter number :");

string strNumber = Console.ReadLine();

int Number1 = Convert.ToInt32(strNumber);

if (Number1 == 1)
{
    System.Console.WriteLine("Monday - no day off");
}
else 
if  (Number1 == 2)
{
    System.Console.WriteLine("Tuesday - no day off");
}

else 
if (Number1 == 3)
{
    System.Console.WriteLine("Wednsday - no day off");
}
    else 
    if (Number1 == 4)
{
    System.Console.WriteLine("Thursday - no day off");
}
else 
if (Number1 == 5)
{
    System.Console.WriteLine("Friday -no day off");
}
else
 if (Number1 == 6)
{
    System.Console.WriteLine("Saturday - day off");
}
else
if (Number1 == 7)
{
    System.Console.WriteLine("Sunday - day off");
}
else {
    Console.WriteLine("Absent day");
}
