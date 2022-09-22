// Программа выводит на экран массив из 8 элементов, которые вводит пользователь

int [] MetodArray (int a, int b, int c, int d, int e, int f, int g, int h)
{
    int [] array = new int [8];
    array [0] = a;
    array [1] = b;
    array [2] = c;
    array [3] = d;
    array [4] = e;
    array [5] = f;
    array [6] = g;
    array [7] = h;
    return array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]} ");
    }
    return;
}

try
{
    Console.Write ("Введите число: ");
    int a = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите число: ");
    int b = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите число: ");
    int c = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите число: ");
    int d = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите число: ");
    int e = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите число: ");
    int f = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите число: ");
    int g = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите число: ");
    int h = Convert.ToInt32 (Console.ReadLine());

    int [] array = MetodArray (a, b, c, d, e, f, g, h);
    PrintArray (array);
}
catch
{
   Console.Write ("Ошибка: не верно введены данные."); 
}