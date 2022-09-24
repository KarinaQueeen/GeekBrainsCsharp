// Программа находит произведение двух матриц

int [,] GetNewArray (int m, int n)
{
    int [,] newArray = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray [i, j] = new Random ().Next (1,5);
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
    
try
{
    Console.Write ("Введите количество строк 1 матрицы: ");
    int m = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите количество столбцов 1 матрицы: ");
    int n = Convert.ToInt32 (Console.ReadLine ());

    int [,] arrayOne = GetNewArray (m, n);

    Console.Write ("Введите количество строк 2 матрицы: ");
    int a = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите количество столбцов 2 матрицы: ");
    int b = Convert.ToInt32 (Console.ReadLine ());
    
    int [,] arrayTwo = GetNewArray (a, b);

    PrintArray (arrayOne);
    Console.WriteLine("    X");
    PrintArray (arrayTwo);
    Console.WriteLine("    =");
    
    int [,] newArray = new int [arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    
    if (arrayOne.GetLength (1) == arrayTwo.GetLength (0))
    {
        for (int i = 0; i < arrayOne.GetLength (0); i++)
        {
            for (int k = 0; k < arrayTwo.GetLength (1); k++)
            {
                for (int j = 0; j < arrayTwo.GetLength (0); j++)
                {
                    newArray [i, k] += arrayOne[i, j] * arrayTwo[j, k];
                } 
            }  
        }  
        PrintArray (newArray);
    }
    else Console.WriteLine("Такие матрицы не получится перемножить! Количество столбцов 1 матрицы должно быть равно количеству строк 2 матрицы.");
}
catch
{
   Console.Write ("Неверно введены данные!");
}

