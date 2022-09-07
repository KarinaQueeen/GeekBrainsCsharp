// Программа проверяет номер дня недели относится он к выходному дню или нет

Console.Write ("Введите номер дня недели (от 1 до 7): ");
int day = Convert.ToInt32 (Console.ReadLine ());
if (day>0)
if (day<=7)
if (day >5)
    Console.Write ($"{day} день недели выходной!");
else
    Console.Write ($"{day} день недели будний.");
else
    Console.Write ("Вы ввели число не из нужного диапозона, запустите программу снова и измените число.");
