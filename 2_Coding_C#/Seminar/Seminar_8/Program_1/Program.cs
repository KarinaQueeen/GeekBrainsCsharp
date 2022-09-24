// Программа поменяет местами первую и последнюю строку двумерного массива

int [,] GetNewArray (int m, int n)
{
    int [,] newArray = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray [i, j] = new Random ().Next (1,10);
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

int [,] Metod (int [,] newArray)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        int tmp = newArray [0, j];
        newArray [0, j] = newArray [newArray.GetLength(0) - 1, j];
        newArray [newArray.GetLength(0) - 1, j] = tmp;
    }
    return  newArray;
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
    Metod (array);
    PrintArray (array);
}
catch
{
   Console.Write ("Неверно введены данные!");
}