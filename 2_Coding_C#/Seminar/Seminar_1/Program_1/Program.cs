// Программа находит квадрат числа

Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine ());

int result_1 = number*number;
Console.WriteLine ($"Квадрат числа {number} = {result_1}"); 

// или

int result_2 = Convert.ToInt32(Math.Pow (number, 2));  
Console.WriteLine ($"Квадрат числа {number} = {result_2}");