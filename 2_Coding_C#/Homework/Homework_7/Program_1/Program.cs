// Программа задает массив размером m х n случайными вещественными числами

double [,] GetNewArray (int m, int n)
{
    double [,] newArray = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray [i,j] = new Random ().Next (1,10);
        }
    }
    return newArray;
}

void PrintNewArray (double [,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write ($"{newArray [i,j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Write ("Введите количество строк: ");
int m = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Введите количество столбцов: ");
int n = Convert.ToInt32 (Console.ReadLine ());

double [,] array = GetNewArray (m, n);
PrintNewArray (array);