// Программа выводит все числа двухмерного массива как сложенные их индекс строки и столбца

void FillArray (int [,] matr)                          
{
    for (int i = 0; i < matr.GetLength(0); i++)    
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = i+j;   
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

Console.Write ("Введите количество строк: ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите количество столбцов: ");
int m = Convert.ToInt32 (Console.ReadLine());

int [,] array = new int [n,m];

FillArray (array);
PrintArray (array);

