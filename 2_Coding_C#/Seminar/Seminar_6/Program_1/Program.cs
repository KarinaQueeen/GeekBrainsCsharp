// Программа перевернет массив с помощью дополнительного массива

int [] GetArray (int size)
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
        Console.Write ($"{array [i]} ");
    }
    return;
}

int [] Metod (int[] array)
{
    int[] newArray = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[array.Length - 1 - i]; 
    }
    return newArray; 
}
    
int[] arr = GetArray (9);
PrintArray (arr);
Console.WriteLine();
int[] newArr = Metod (arr);
PrintArray (newArr);