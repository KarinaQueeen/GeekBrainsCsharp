// Программа вычисляет функцию Аккермана от чисел A(m, n), которые вводит пользователь

int FunctionAkkermana (int m, int n)
{
    int result;
    if (m == 0)
    {
        return n + 1;   
    }
    if (n == 0)
    {
        result = FunctionAkkermana (m - 1, 1);   
    }
    else
    {
        result = FunctionAkkermana (m - 1, FunctionAkkermana (m, n - 1));
    }
    return result;
} 

try
{   
    Console.WriteLine ("Введите положительные числа m и n для функции A (m, n): ");
    int m = Convert.ToInt32 (Console.ReadLine());
    int n = Convert.ToInt32 (Console.ReadLine());
    int result = FunctionAkkermana (m, n);
    Console.WriteLine (result);
}
catch
{
    Console.Write ("Введите конец отрезка: ");
}
       
