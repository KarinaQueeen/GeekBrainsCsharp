// Программа найдет точку пересечения двух прямых, заданными уравнениями y = a1 * x + a2, y = b1 * x + b2, которые задает пользователь

Console.WriteLine("Введите  2 числа для первого уравнения y = a1 * x + a2: ");
int a1 = Convert.ToInt32 (Console.ReadLine ());
int a2 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("Введите  2 числа для первого уравнения y = b1 * x + b2: ");
int b1 = Convert.ToInt32 (Console.ReadLine ());
int b2 = Convert.ToInt32 (Console.ReadLine ());

int x = (b2-a2)/(a1-b1);
int y = a1 * x + a2;

char z1 = '+';
char z2 = '+'; 
if (a2<0) z1 = '-';
if (b2<0) z2 = '-';

Console.WriteLine($"Точка пересечения уравнений y = {a1}x {z1} {Math.Abs(a2)}, y = {b1}x {z2} {Math.Abs(b2)} имеет координаты ({x}, {y})");