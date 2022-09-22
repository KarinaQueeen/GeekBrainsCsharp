// Программа проверяет является ли первое число квадратом второго

Console.WriteLine ("Введите два числа: ");
int number_1 = Convert.ToInt32(Console.ReadLine ());
int number_2 = Convert.ToInt32(Console.ReadLine ());

if(number_1 == number_2 * number_2)
{
    Console.WriteLine ($"{number_1} квадрат числа {number_2}");
}
else
{
    Console.WriteLine ($"{number_1} не является квадратом числа {number_2}");
} 

    