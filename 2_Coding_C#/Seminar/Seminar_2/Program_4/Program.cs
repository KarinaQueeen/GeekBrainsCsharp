// Программа показывает является ли первое число кратно второму

Console.Write ("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());

int c = a % b;

if (c == 0) Console.Write ($"{a} кратно {b}.");
else Console.Write ($"{a} не кратно {b}, остаток {c}.");