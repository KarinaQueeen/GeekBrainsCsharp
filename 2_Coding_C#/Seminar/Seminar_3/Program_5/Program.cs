﻿// Программа выдает таблицу квадратов от 1 до N введенного пользователем

Console.Write("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());

for (int i = 1; i<=a; i++)
{
    double result = Math.Pow(i,2);
    Console.WriteLine(result);
}