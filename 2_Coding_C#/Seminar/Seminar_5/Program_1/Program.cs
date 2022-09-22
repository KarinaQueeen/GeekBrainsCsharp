// Программа выдает массив из 12 элементов от -9 до 9 и показыает сумму положительных и отрицательных чисел

int[] GetArray (int size, int start, int end)
{
    var array = new int [size];    

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (start, end + 1);
    }    
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

int SumPositiveNumbers (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            sum = sum +array [i];  
        }
    }
    return sum;
}

int SumNegativeNumbers (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < 0)
        {
            sum = sum +array [i];  
        }
    }
    return sum;
}

try
{
    int[] array = GetArray (12, -9, 9);
    PrintArray (array);
    int sum1 = SumPositiveNumbers (array);
    int sum2 = SumNegativeNumbers (array);
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных чисел массива = {sum1}");
    Console.WriteLine($"Сумма отрицательных чисел массива = {sum2}");
}
catch
{
    Console.Write ("Ошибка: не верно введены данные.");
}
