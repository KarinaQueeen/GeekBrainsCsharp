// Сортировка

int [] array = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray (int [] arr)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

PrintArray (array);

void Sort (int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int indexMin = i;
        for (int j = i + 1; j < array.Length; j++)    // j=i+1 позиция с которой начинается сортировка 
        {
            if (array [j] < array [indexMin])
            indexMin = j;
        }

        int x = array [i];                           // временный элемент
        array [i] = array [indexMin];                // элемент массива во временный элемент, минимальный элемент в элемент массива, временный обратно на место где был минимальный
        array [indexMin] = x;
    }
}

Sort (array);
PrintArray (array);