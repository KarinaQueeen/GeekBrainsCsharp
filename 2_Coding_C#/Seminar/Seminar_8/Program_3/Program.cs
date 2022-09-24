// Программа выводит частотный словарь элементов

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

int [] Metod (int [,] newArray)
{
    int [] sum = new int [10];
      
    for (int j = 0; j < newArray.GetLength(0); j++)
    {
        for (int k = 0; k < newArray.GetLength(1); k++)
        {
            for (int i = 0; i < sum.Length; i++)
            {
                if (newArray [j, k] == i) 
                sum [i] += 1;
            }  
        }
    }
    return sum;
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
    int [] sumElements = Metod (array);
    for (int i = 0; i < 10; i++)
    {
        if (sumElements[i] != 0)
        {
            Console.WriteLine($"{i} встречается {sumElements[i]} раз");  
        }
    }
}
catch
{
   Console.Write ("Неверно введены данные!");
}