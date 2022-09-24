// Программа создает и выводит трехмерный массив из неповторяющихся двухзначных элементов с их индексами 

int [,,] GetNewArray (int k, int m, int n)
{
    int [,,] newArray = new int [k, m, n];
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int l = 0; l < n; l++)
            {
                int t;
                lab: t = new Random ().Next (10,100);
                for(int f = 0; f < 100; f++)
                {
                    if (newArray[i, j, l] == t)
                    {
                        goto lab;
                    }
                }
                newArray[i, j, l] = t;
            }            
        }
    }




    
    return newArray;
}

void PrintArray (int [,,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int l = 0; l < newArray.GetLength(2); l++)
            {
                Console.WriteLine ($" {newArray [i, j, l]} ({i}, {j}, {l})");
            }
        }
    }
}

try
{
    Console.WriteLine ("Введите размеры трехмерного массива (z, y, x): ");
    int z = Convert.ToInt32 (Console.ReadLine ());
    int y = Convert.ToInt32 (Console.ReadLine ());
    int x = Convert.ToInt32 (Console.ReadLine ());
    int [,,] array = GetNewArray (z, y, x);
    PrintArray (array);
}
catch
{
   Console.Write ("Неверно введены данные!");
}