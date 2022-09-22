// Программа найдет среднее арифметическое в каждом столбце

double [,] GetNewArray (int m, int n)
{
    double [,] newArray = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray [i, j] = new Random ().Next (1,10);
        }
    }
    return newArray;
}

void PrintTwoArray (double [,] newArray)
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

void PrintOneArray (double [] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        string result = string.Format ("{0:f1}", newArray [i]);
        Console.Write ($"{result}  ");
    }
}

double [] ArithmeticMeanColumn (double [,] newArray)
{
    double [] sum = new double [newArray.GetLength(1)];
    for (int j = 0, i = 0; j < newArray.GetLength(1); j++, i++)
    {
        for (int k = 0; k < newArray.GetLength(0); k++)
            {
                sum [i] += newArray [k, j]; 
            }
    }

    double [] arithmeticMean = new double [sum.Length];
    for (int i = 0; i < arithmeticMean.Length; i++)
        {
            arithmeticMean [i] = sum [i] / newArray.GetLength(0);                 
        }
    return  arithmeticMean;
}

try
{
    Console.Write ("Введите количество строк: ");
    int m = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите количество столбцов: ");
    int n = Convert.ToInt32 (Console.ReadLine ());

    double [,] array = GetNewArray (m, n);
    PrintTwoArray (array);
    ArithmeticMeanColumn (array);
    double [] arithmeticMeanArray = ArithmeticMeanColumn (array);
    PrintOneArray (arithmeticMeanArray);
}

catch
{
   Console.Write ("Неверно введены данные!");
}