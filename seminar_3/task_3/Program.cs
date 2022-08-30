// Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
Console.Write("Введите число и нажмите клавишу Enter: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
for (int i = 1; i<N+1; i++)
{
    array[i-1] = i * i * i;
}
var str = string.Join(" ", array);
Console.WriteLine(str);
