// Программа находит максимальное из трех чисел

Console.WriteLine ("Введите три числа для нахождения максимального: ");
int number_1 = Convert.ToInt32(Console.ReadLine ());
int number_2 = Convert.ToInt32(Console.ReadLine ());
int number_3 = Convert.ToInt32(Console.ReadLine ());

int max_1 = Math.Max(number_1, number_2);
int max = Math.Max(max_1, number_3);
Console.WriteLine ($"Максимальное число {max}");