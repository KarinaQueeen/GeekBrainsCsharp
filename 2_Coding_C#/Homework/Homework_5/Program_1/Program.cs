// Программа выводит новый массив из произведений двух крайних чисел массива

int[] GetArray (int size)
{
    var array = new int [size];

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(1, 10);
    }    
    return array;
}

int [] Metod (int[] array)
{
    if (array.Length % 2 == 0)
    {
        int size = array.Length/2;
        int[] newArray = new int [size];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = array[i] * array[array.Length - i - 1]; 
        }
        return newArray; 
    }
    else
    {
        int size = array.Length/2 + 1;
        int[] newArray = new int [size];
        for (int i = 0; i < size - 1; i++)
        {
            newArray[i] = array[i] * array[array.Length - i - 1]; 
        }
        newArray[size - 1] = array[size - 1];
        return newArray; 
    }
    
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]} ");
    }
    return;
}

try
{
    Console.Write ("Введите размер массива: ");
    int size = Convert.ToInt32 (Console.ReadLine ());
    int[] array = GetArray (size); 
    Console.Write ("Старый массив: ");
    PrintArray (array);
    Console.WriteLine();
    Console.Write ("Новый массив: ");
    int [] newArray = Metod (array);
    PrintArray (newArray);
}

catch
{
    Console.Write ("Ошибка: не верно введены данные.");
}