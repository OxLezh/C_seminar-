Console.Write("Введите первое число и нажмите клавишу Enter: ");
string input_a = Console.ReadLine();
int a = Convert.ToInt32(input_a);
if (a%2==0)
{
    Console.WriteLine("да");    
}
else
{
    Console.WriteLine("нет");
}