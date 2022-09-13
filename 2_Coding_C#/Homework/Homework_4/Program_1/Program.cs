// Программа возводит число A в натуральную степень B, которые вводит пользователь

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите степень: ");
int x = Convert.ToInt32 (Console.ReadLine());
int result = number;
if (number==0) result = 0;
Console.Write ($"{number} в степени {x} = {result} ");

if (x==0) result = 1;
 Console.Write ($"{number} в степени {x} = {result} ");

if (x>0)
    {
    for (int i = 1; i < x; i++)
    {
    result =   result*number; 
    }

    Console.Write ($"{number} в степени {x} = {result} ");
    }
else Console.Write ("Степень должна быть положительной!");