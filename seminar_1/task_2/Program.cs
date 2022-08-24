Console.Write("Введите первое число и нажмите клавишу Enter: ");
string input_a = Console.ReadLine();
int a = Convert.ToInt32(input_a);
Console.Write("Введите второе число и нажмите клавишу Enter: ");
string input_b = Console.ReadLine();
int b = Convert.ToInt32(input_b);

int max = 0;
if (a>b) max = a;
else max = b;
    
Console.WriteLine("Максимальное число: " + max);   
