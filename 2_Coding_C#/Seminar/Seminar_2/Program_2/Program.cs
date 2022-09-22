// Программа выводит случайное число из отрезка [10, 99] и показывает большую цифру числа 

void CompareDigits ()                                       
{
    int a = new Random ().Next (10,100);
    int a1 = a/10;
    int a2 = a%10;
    Console.WriteLine($"Случайное число {a}.");
    if (a1>a2) Console.WriteLine("Первая цифра больше.");
    else if (a1<a2) Console.WriteLine("Вторая цифра больше.");
    else Console.WriteLine("Цифры одинаковые.");
}

CompareDigits ();
CompareDigits ();