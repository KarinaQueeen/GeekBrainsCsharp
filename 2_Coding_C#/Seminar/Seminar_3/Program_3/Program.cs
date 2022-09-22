// Программа по номеру четверти выводит диапозон координат

string Metod (int number)
{
    if (number == 1) return "x > 0, y > 0";
    if (number == 2) return "x < 0, y > 0";
    if (number == 3) return "x < 0, y < 0";
    if (number == 4) return "x > 0, y < 0";
    return ("Ошибка!");
}

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32 (Console.ReadLine());

string xy = Metod(number);
Console.WriteLine($"В {number} четверти координаты находятся в диапозоне {xy}.");