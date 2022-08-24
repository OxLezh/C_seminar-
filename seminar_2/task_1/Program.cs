// Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа
int start = 100;
int stop = 999;

int value = new Random().Next(start, stop + 1);
Console.WriteLine(value);
int digit_second = (value % 100) / 10;
Console.Write(digit_second);