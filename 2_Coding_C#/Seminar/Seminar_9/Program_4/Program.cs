// Программа возводит А в степень В, которые вводит пользователь

int Metod (int a, int b)
{
    if (b == 1)
    {
        return 1;
    }
    int num = a * Metod (a, b - 1);
    return num;
}

try
{
    Console.Write ("Введите число: ");
    int a = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите степень: ");
    int b = Convert.ToInt32 (Console.ReadLine());
    int num = Metod (a, b);
    Console.Write ($"{a} в степени {b} = {num}");  
}
catch
{
  Console.Write ("Неверно введены данные");  
}


