// Программа показывает все целые числа в промежутке от "-n" до  "n", которое вводит пользователь

Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine ());

int startNumber = Math.Abs(number)*-1; // Преобразование числа в положительное

while (startNumber <= number)
    {
        Console.Write ($"{startNumber} ");
        startNumber++;
    }
