// Прграмма упорядочит по убыванию элементы строк двумерного массива

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

void Sort (int [,] newArray)
{
    for (int k = 0; k < newArray.GetLength(0); k++)
    {
        for (int i = 0; i < newArray.GetLength(1); i++)
        {
            int indexMax = i;
            for (int j = i + 1; j < newArray.GetLength(1); j++)   
            {
                if (newArray [k, j] > newArray [k, indexMax])
                indexMax = j;
            }
            int x = newArray [k, i];                          
            newArray [k, i] = newArray [k, indexMax];                
            newArray [k, indexMax] = x;
        } 
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
    Sort (array);
    PrintArray (array);
}
catch
{
   Console.Write ("Неверно введены данные!");
}

