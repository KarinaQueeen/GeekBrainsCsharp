// Программа считает сумму элементов в диаганали

void FillArray (int [,] matr)                          
{
    for (int i = 0; i < matr.GetLength(0); i++)    
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
             matr [i,j] = new Random().Next(1,10); 
        }                    
    }
}

void PrintArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)    
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write ($"{matr[i,j]} ");      
        }
        Console.WriteLine();                       
    }
}

int SumArray (int [,] matr)
{
    int sum = 0;
     for (int i = 0; i < matr.GetLength(0); i++)    
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sum = sum + matr [i,j];
        }                    
    }  
    return sum;
}

Console.Write ("Введите количество строк: ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите количество столбцов: ");
int m = Convert.ToInt32 (Console.ReadLine());

int [,] array = new int [n,m];

FillArray (array);
PrintArray (array);

int sumArray = SumArray (array);
Console.WriteLine($"Сумма элементов на главной диаганали = {sumArray}");

