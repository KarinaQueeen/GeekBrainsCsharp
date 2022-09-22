// Программа покажет количество чётных элементов в массиве из трехзначных чисел

int[] GetArray (int size, int startArray, int finishArray)
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(startArray, finishArray + 1);
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


int QuantityEvenNumbers (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (Math.Abs(array[i]) % 2 == 0)
        sum ++;
    }
    return sum;
}

try
{
    Console.Write ("Введите размер массива: ");
    int size = Convert.ToInt32 (Console.ReadLine ()); 
    if (size == 0) size = -1;                                         
    Console.Write ("Введите начала диапазона чисел массива: ");
    int start = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите конец диапазона чисел массива: ");
    int end = Convert.ToInt32 (Console.ReadLine ());

    int[] array = GetArray (size, start, end);
    
    int quantityNumbers = QuantityEvenNumbers (array);
    Console.Write ($"Количество четных чисел в массиве: ");
    PrintArray (array);
    Console.Write ($"= {quantityNumbers}");
}
catch
{
    Console.Write ("Ошибка: не верно введены данные.");
}

