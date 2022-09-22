// Программа выдает количество цифр в числе

int Metod (int number)
{
    int index = 1;
    int num = Math.Abs(number);

    while (num > 10)
    {
        num = num / 10;
        index++;
    }   
    return index;
}

try
{
    Console.Write ("Введите число: ");
    int a = Convert.ToInt32 (Console.ReadLine());
    int result = Metod (a);
    Console.WriteLine($"Количество цифр в числе {a} = {result}");  
}
catch (Exception)
{
    Console.WriteLine ("Входное значение имеет неверный формат.");
}