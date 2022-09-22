// Программа возвращает значение элемента массива по его позиции

int [,] GetNewArray (int m, int n)
{
    int [,] newArray = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray [i,j] = new Random ().Next (1,10);
        }
    }
    return newArray;
}

void PrintNewArray (int [,] newArray)
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

try
{
    Console.Write ("Введите количество строк массива: ");
    int m = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите количество столбцов массива: ");
    int n = Convert.ToInt32 (Console.ReadLine ());

    int [,] array = GetNewArray (m, n);
    PrintNewArray (array);

    Console.WriteLine ("Введите положение нужного элемента (строку, стоблец): ");
    int x = Convert.ToInt32 (Console.ReadLine ()); 
    int y = Convert.ToInt32 (Console.ReadLine ());

    Console.WriteLine($"({array [x - 1, y - 1]}) тот самый элемент!");
}

catch
{
   Console.WriteLine("Такого элемента не существует!"); 
}