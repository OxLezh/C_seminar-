// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int start = 1;
int stop = 7;
int value = new Random().Next(start, stop + 1);
Console.WriteLine(value);

switch (value.ToString())
{
    case "6":
        Console.WriteLine("Сегодня Выходной :) ");
        break;
    case "7":
        Console.WriteLine("Сегодня Выходной :) ");
        break;
    default:
        Console.WriteLine("Сегодня рабочий день :( ");
        break;
}






