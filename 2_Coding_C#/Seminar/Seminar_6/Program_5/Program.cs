// Программа выводит числа Фибоначи

int [] GetFibonacci (int numbers)
{
    int [] array = new int [numbers];

    for (int i = 0; i < numbers; i++)
    {
        if (i == 0) array[i] = 0;
        else if (i == 1 || i == 2) array[i] = 1;
        else array[i] = array [i - 2] + array [i - 1];
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

Console.WriteLine("Введите количество чисел Фибоначи:");
int numbers = Convert.ToInt32(Console.ReadLine());

int [] fibonacci = GetFibonacci(numbers);
Console.WriteLine($"Первые {numbers} чисел Фибоначи: ");
PrintArray (fibonacci);