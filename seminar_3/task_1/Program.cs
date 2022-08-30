// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string)

Console.Write("Введите число и нажмите клавишу Enter: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10000;
int b = (number % 10000) / 1000;
int d = (number % 100)/ 10;
int e = number%10;

if (a == e && b == d) 
{
    Console.WriteLine("Число " + number + " является палиндромом");
}
else
 {
    Console.WriteLine("Число " + number + " не является палиндромом");
 }
