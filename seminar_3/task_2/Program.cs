// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координату x для точки A и нажмите клавишу Enter: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y для точки A и нажмите клавишу Enter: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z для точки A и нажмите клавишу Enter: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x для точки B и нажмите клавишу Enter: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y для точки B и нажмите клавишу Enter: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z для точки B и нажмите клавишу Enter: ");
int z2 = Convert.ToInt32(Console.ReadLine());
int degree = 2;
int [] A = new int [] {x1, y1, z1};
int [] B = new int [] {x2, y2, z2} ;
double result = Math.Round(Math.Sqrt(Math.Pow((B[0] - A[0]), degree) + Math.Pow((B[1] - A[1]), degree) + Math.Pow((B[2] - A[2]), degree)), 3);
Console.WriteLine("Расстояние между точками A и B: " + result);