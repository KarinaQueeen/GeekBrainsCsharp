// Программа выводит массив, где элемент заменяет на произведение его индекса строки на индекс столбца

void FillArray (int [,] matr)                          
{
    for (int i = 0; i < matr.GetLength(0); i++)    
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matr [i,j] = i*j;   
            else  matr [i,j] = 0;
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
