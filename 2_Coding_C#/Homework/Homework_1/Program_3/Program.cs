// Программа определяет четное число

Console.WriteLine ("Введите число: ");
int number = int.Parse(Console.ReadLine ());

if (number%2 == 0)
    {
        Console.WriteLine ($"{number} четное число");
    }
else
    {
        Console.WriteLine ($"{number} нечетное число");
    }