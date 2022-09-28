// Программа считает сумму цифр введенного числа

int SumNum (int n)
{
    if (n == 0)
    {
        return 0;
    }
    int sum = n % 10 + SumNum (n / 10);
    return sum;
}

try
{
    Console.Write ("Введите число: ");
    int n = Convert.ToInt32 (Console.ReadLine());
    int sum = SumNum (n);
    Console.Write ($"Сумма цифр в числе {n} = {sum}");  
}
catch
{
  Console.Write ("Неверно введены данные");  
}

