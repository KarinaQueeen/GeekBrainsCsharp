// Программа находит квадрат числа
// Определение числа
Console.WriteLine ("Введите число: ");
int number = int.Parse(Console.ReadLine ());

// Получение квадрата
int result = number*number;
Console.WriteLine ($"Квадрат числа {number} = {result}"); 

// Получение квадрата входного числа с помощью математического уравнения 
int result_2 = Convert.ToInt32(Math.Pow (number, 2));   //Преобразование ???
Console.WriteLine ($"Квадрат числа {number} = {result_2}");