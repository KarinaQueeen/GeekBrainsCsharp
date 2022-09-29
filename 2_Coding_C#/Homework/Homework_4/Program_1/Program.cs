// Программа возводит число A в натуральную степень B, которые вводит пользователь

int MetodDegree (int number, int  degree)
{
    int result = number;
    if (number == 0) result = 0;
    if (degree == 0) result = 1;
    if (degree > 0)
    {
        for (int i = 1; i < degree; i++)
        {
            result = result * number;
        }  
    }
    if (degree < 0) result = -1;
    return result;
}
try
{
    Console.Write ("Введите число: ");
    int a = Convert.ToInt32 (Console.ReadLine());

    Console.Write ("Введите степень: ");
    int b = Convert.ToInt32 (Console.ReadLine());

    int degreeAB = MetodDegree (a,b);
    if (degreeAB == -1) Console.Write("Степень должна быть положительной!");
    else Console.Write ($"{a} в степени {b} = {degreeAB} ");      
}
catch
{
    Console.Write ("Ошибка: не верно введены данные.");
}


