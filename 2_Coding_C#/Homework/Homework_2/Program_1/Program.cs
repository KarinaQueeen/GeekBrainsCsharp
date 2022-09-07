// Программа выводит второую цифру у трехзначного числа

Console.Write ("Введите трехзначное число: ");
int a = Convert.ToInt32 (Console.ReadLine());
int b = Math.Abs(a);
int c = b/10%10;

if ((b/100)>=1)
if ((b/1000)<1)
Console.WriteLine($"{c} вторая цифра числа {a}.");
else
Console.WriteLine($"Число {a} не трехзначное.");