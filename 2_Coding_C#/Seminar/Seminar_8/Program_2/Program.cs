// Программа меняет строки на столбцы двумерного массива

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

try
{
    Console.Write ("Введите количество строк: ");
    int m = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите количество столбцов: ");
    int n = Convert.ToInt32 (Console.ReadLine ());

    int [,] array = GetNewArray (m, n);
    PrintArray (array);
    Console.WriteLine();
    
    if (m == n)
    {
      int [,] newArray = new int [m, n];
      
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                newArray [i, j] = array [j, i];
            }
        }
        PrintArray (newArray);
    }
    else Console.WriteLine("Разворот данного массива выполнить не получится, так как количество строк не соответствует количеству столбцов"); 
}
catch
{
   Console.Write ("Неверно введены данные!");
}
