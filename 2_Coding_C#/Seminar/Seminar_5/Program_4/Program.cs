// Программа находит количество элементов из отрезка от 10 до 99 в массиве из 123 случайных чисел

int[] GetArray (int size)
{
    var array = new int [size];

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(1, 1000);
    }    
    return array;
}

int Metod (int[] array, int start, int end)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>start && array[i]<end+1)
        sum ++;
    }
    return sum;
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
    Console.Write ("Введите размер массива: ");
    int size = Convert.ToInt32 (Console.ReadLine ()); 
    Console.Write ("Введите начала отрезка: ");
    int start = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите конец отрезка: ");
    int end = Convert.ToInt32 (Console.ReadLine ());

    int[] array = GetArray (size);
    PrintArray (array);
    int sumNumber = 0;
    sumNumber = Metod (array, start, end);
    Console.WriteLine();
    Console.WriteLine($"Количество чисел в массиве из диапазона (10, 99) = {sumNumber}");
}

catch
{
    Console.Write ("Ошибка: не верно введены данные.");
}
