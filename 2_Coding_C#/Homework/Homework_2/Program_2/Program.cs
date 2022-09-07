// Программа выводит третью цифру числа

Console.Write ("Введите  число: ");
int a = Convert.ToInt32 (Console.ReadLine());
int b = Math.Abs(a);

if (b/100 >0)
    {
        while (b>=1000)
            {
                b = b/10;
            }
        int c = b%10;
        Console.WriteLine($"{c} третья цифра числа {a}.");
    }
else
    {
        Console.WriteLine($"В числе {a} нет третьей цифры.");   
    }
