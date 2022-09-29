// Программа выдаст номер строки в которой сумма элементов наименьшая из всех в двумерном массиве

int [,] GetNewArray (int m, int n)
{
    int [,] newArray = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray [i, j] = new Random ().Next (0,10);
        }
    }
    return newArray;
}

void PrintArray (int [,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write ($" {newArray [i, j]}   ");
        }
        Console.WriteLine();
    }
}

int [] SumLine (int [,] newArray)
{
    int [] sum = new int [newArray.GetLength(0)];
    for (int k = 0; k < newArray.GetLength(0); k++)
    {
        for (int i = 0; i < newArray.GetLength(1); i++)
        {
            sum [k] = sum [k] + newArray [k, i]; 
        }
    }
    return sum;
}

int NumberMinSumLine (int [] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array [index]) 
        {
            array [index] = array [i];
            index = i;
        }
    }
    return index;
}
   
try
{
    Console.Write ("Введите количество строк: ");
    int m = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите количество столбцов: ");
    int n = Convert.ToInt32 (Console.ReadLine ());

    int [,] array = GetNewArray (m, n);
    PrintArray (array);
    Console.WriteLine();
    int [] sum = SumLine (array);
    int indexMinSum = NumberMinSumLine (sum);
    Console.WriteLine($"Минимальная сумма ({sum [indexMinSum]}) в {indexMinSum + 1} строке.");
}
catch
{
   Console.Write ("Неверно введены данные!");
}
