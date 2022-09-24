// Программа удаляет строку и столбец на пересечении минимального элемента массива

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

int [] MinElement (int [,] newArray)
{
    int min = newArray [0,0];
    int [] minArray = new int [3];
    for (int j = 0; j < newArray.GetLength(0); j++)
    {
        for (int k = 0; k < newArray.GetLength(1); k++)
        {      
            if (newArray [j, k] < min) 
            {
            min = newArray [j, k];
            minArray [1] = j;
            minArray [2] = k; 
            } 
        }
    }
    minArray [0] = min;
    return minArray;
}

int [,] DeleteLinesColumn (int [,] array, int lines, int column)
{
    int [,] newArray = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0, k = 0; i < array.GetLength(0); i++)
    {    
        if (i == lines) continue; 

        for (int j = 0, u = 0; j < array.GetLength(1); j++)
        {
            if (j == column) continue;  

            newArray [k, u] = array [i, j]; 
            u++;
        }
        k++;
    }
    return newArray;         
}

try
{
    Console.Write ("Введите количество строк: ");
    int m = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите количество столбцов: ");
    int n = Convert.ToInt32 (Console.ReadLine ());

    int [,] array = GetNewArray (m, n);
    PrintArray (array);
    int [] min = MinElement(array);
    Console.WriteLine();
    Console.WriteLine($"Минимальный элемент {min [0]}");
    Console.WriteLine();
    int [,] newArray = DeleteLinesColumn (array, min [1], min [2]);
    PrintArray (newArray);
    
}
catch
{
   Console.Write ("Неверно введены данные!");
}