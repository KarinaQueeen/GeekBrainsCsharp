// Программа сравнивает два числа

Console.WriteLine ("Введите два числа для сравнения: ");
int number_1 = Convert.ToInt32(Console.ReadLine ());
int number_2 = Convert.ToInt32(Console.ReadLine ());

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