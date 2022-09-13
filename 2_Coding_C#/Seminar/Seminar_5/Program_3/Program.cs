// Программа проверяет присутствует ли число в массиве

bool Metod (int [] array, int number)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
       if (array [i] == number) 
       {
            result = true;
            break;
       }
       else result = false;
       
    }
    return result;
}

try
{
    Console.Write ("Введите число: ");
    int number = Convert.ToInt32 (Console.ReadLine ()); 
    int [] array = {5, -4, 5, -1, 0};
    var result = Metod (array, number);
    Console.WriteLine(result);
}

catch
{
    Console.Write ("Ошибка: не верно введены данные.");
}