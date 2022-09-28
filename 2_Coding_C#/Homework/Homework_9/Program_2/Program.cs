// Программа находит сумму всех чисел из прмежутка от M до N, которые вводит пользователь

int SumNum (int n, int m)
{
    if (n == m)
    {
        return m;  
    }
    int sum = n + SumNum (n + 1, m) ;
    return sum;
} 

try
{   
    Console.Write ("Введите начало отрезка: ");
    int n = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите конец отрезка: ");
    int m = Convert.ToInt32 (Console.ReadLine());
    int sum = SumNum (n, m);
    Console.WriteLine ($"Сумма чисел от {n} до {m} = {sum}");
}
catch
{
    Console.Write ("Введите конец отрезка: ");
}
       
