// Программа выдает таблицу квадратов от 1 до N введенного пользователем

int [] Metod (int number)
{
    int [] array = new int[number]; 
    for (int i = 1; i<=number; i++)
    {
        array [i-1]=i*i;
    } 
    return array;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());

int [] result = Metod (a);
for (int i = 0; i<result.Length; i++)
Console.Write($"{result[i]} ");
