// Программа найдет разницу между максимальным и минимальным элементом массива вещественных чисел

void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]} ");
    }
    return;
}

double MaxNumber (double[] array)
{
    double maxNumber = array [0]; 
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}

double MinNumber (double[] array)
{
    double minNumber = array [0]; 
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}


double DifferenceMinMaxNumbers (double max, double min)
{
    double difference = max - Math.Abs(min);
   
    return difference;
}

    double[] array = {1.1, 5.3, 18, 6, 2.5, -5.55, 0, -1.1};
    
    double max = MaxNumber (array);
    double min = MinNumber (array);
    double diff = DifferenceMinMaxNumbers (max, min);
    
    Console.Write ($"Разница между максимальным и минимальным числом массива: ");
    PrintArray (array);
    Console.Write ($"= {diff}");
