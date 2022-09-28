// Программа выводит все числа из прмежутка от M до N, которые вводит пользователь

string Numbers (int n, int m)
{
    if (n == m)
    {
        return $"{m}";   
    }
    string num = n + " " + Numbers (n + 1, m) ;
    return num;
} 

try
{   
    Console.Write ("Введите начало отрезка: ");
    int n = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите конец отрезка: ");
    int m = Convert.ToInt32 (Console.ReadLine());
    string numbers = Numbers (n, m);
    Console.WriteLine (numbers);
}
catch
{
    Console.Write ("Введите конец отрезка: ");
}
       
