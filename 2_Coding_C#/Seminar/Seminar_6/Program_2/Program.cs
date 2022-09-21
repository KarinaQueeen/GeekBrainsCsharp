// Программа переворачивает массив с помощью запоминающей переменной

int [] ReversArray (int [] array)
{
    int tempStorage = array [0];

    for (int i = 0; i < array.Length/2; i++)
    {
        tempStorage = array [i];
        array [i] = array [array.Length-1-i];
        array [array.Length-1-i] = tempStorage;
    }
    return array;
}

int[] GetArray (int size)
{
    var array = new int [size];

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(1, 100);
    }    
    return array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array [i] +" ");
    }
    return;
}

int[] arr = GetArray (9);
PrintArray (arr);
Console.WriteLine();
int[] newArr = ReversArray (arr);
PrintArray (newArr);