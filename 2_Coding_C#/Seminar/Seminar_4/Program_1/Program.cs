// Программа выдает сумму всех чисел от 1 до А, которые вводит пользователь

int Metod (int number)
{
    int sum = 0;
    if (number==0) sum = 1;
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            sum = sum + i; 
        }
    }
    if (number < 0)
    {
        for (int i = 1; i >= number; i--)
        {
            sum = sum + i; 
        }   
    }
        return sum;
}


try
{
    Console.Write ("Введите число: ");
    int a = Convert.ToInt32 (Console.ReadLine());
    int result = Metod (a);
    Console.WriteLine($"Сумма чисел от 1 до {a} = {result}");  
}
catch (Exception)
{
    Console.WriteLine ("Входное значение имеет неверный формат.");
}