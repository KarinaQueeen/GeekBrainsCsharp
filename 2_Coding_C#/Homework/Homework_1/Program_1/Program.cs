// Программа сравнивает два числа

Console.WriteLine ("Введите два числа для сравнения: ");
int number_1 = int.Parse(Console.ReadLine ());
int number_2 = int.Parse(Console.ReadLine ());

if (number_1 > number_2)
    {
        Console.WriteLine ($"{number_1} больше {number_2}");
    }
if (number_2 > number_1)
    {
        Console.WriteLine ($"{number_1} меньше {number_2}");
    }
if (number_1 == number_2)
    {
        Console.WriteLine ($"{number_1} и {number_2} равны");
    }