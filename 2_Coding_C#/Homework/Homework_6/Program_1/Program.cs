// Программа показывает сколько положительных чисел ввел пользователь

Console.Write ("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine ());
int [] array = new int [num];
for (int i = 0; i < num; i++)
{
    Console.Write ($"Введите {i+1} число: ");  
    array [i] = Convert.ToInt32(Console.ReadLine ());
}

Console.Write ("Положительных чисел в массиве: ");
for (int i = 0; i < num; i++)
{
    Console.Write($"{array [i]} ");
}

int sum = 0;
for (int i = 0; i < num; i++)
{
    if (array [i] > 0) sum ++;
}

Console.Write ($"= {sum} ");