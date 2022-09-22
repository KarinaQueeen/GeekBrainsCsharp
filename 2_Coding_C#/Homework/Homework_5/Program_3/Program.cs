// Программа найдет сумму элементов массива, стоящих на нечётных позициях 


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


int SumEvenPlaceNumbers (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array [i];    
        }
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
    
    int sumNumbers = SumEvenPlaceNumbers (array);
    Console.Write ($"Сумма чисел на четных позициях массива: ");
    PrintArray (array);
    Console.Write ($"= {sumNumbers}");
}
catch
{
    Console.Write ("Ошибка: не верно введены данные.");
}