// Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.
int start = 1;
int stop = 65536;
int value = new Random().Next(start, stop + 1);
Console.WriteLine(value);
int digits = 0;
if (value < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (value > 999)
    {
        value = value / 10;
        digits++;
    }
    Console.WriteLine("Третья цифра: " + value % 10);
}