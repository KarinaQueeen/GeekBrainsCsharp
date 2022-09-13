// Программа заменяет положительные числа на отрицательные и наоборот

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]} ");
    }
    return;
}

int [] Metod (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array [i] = array [i] * -1;
    }
    return array;
}
    Console.Write("Было: ");
    int [] array = {5, -4, 5, -1, 0};
    PrintArray (array);
    Console.WriteLine();
    Console.Write("Стало: ");
    int [] newArray = Metod (array);
    PrintArray (newArray);

