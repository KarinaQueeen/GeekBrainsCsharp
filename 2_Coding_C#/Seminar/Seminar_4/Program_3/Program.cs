// Программа выдает произведений всех чисел от 1 до N, которые вводит пользователь

int Metod (int number)
{
    int s = 1;
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            s = s * i; 
        }
    }
    if (number <= 0) s = 0; 
    return s;
}
   
try
{
    Console.Write ("Введите число: ");
    int n = Convert.ToInt32 (Console.ReadLine());
    int result = Metod (n);
    Console.WriteLine($"Произведение чисел от 1 до {n} = {result}");  
}
catch (Exception)
{
    Console.WriteLine ("Входное значение имеет неверный формат.");
}