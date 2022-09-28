// Программа выведет все натуральные числа от 1 до N, который введет пользователь и считает их сумму

Console.Write ("Введите конец отрезка: ");
int n = Convert.ToInt32 (Console.ReadLine());

string Numbers (int n)
{
    if (n == 1)
    {
     return "1";   
    }
    string num = Numbers (n - 1) + " " + n;
    return num;
} 

int SumNum (int n)
{
    if (n == 1)
    {
        return 1;
    }
    int sum = n + SumNum (n-1);
    return sum;
}

string numbers = Numbers (n);
Console.WriteLine (numbers);
int sum = SumNum (n);
Console.Write ($"Сумма чисел от 1 до {n} = {sum}");
       
