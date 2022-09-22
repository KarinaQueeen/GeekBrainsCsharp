// Программа ввыводит все четные числа от 1 до N, которое вводит пользователь

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine ());
int startNumber = 2;

if (number<0)
{
    Console.Write ("Вы ввели отрицателльное число");
}
else
{
    while (startNumber <= number)
    {
                
        Console.Write ($"{startNumber} ");
        startNumber = startNumber + 2;  
    }
    Console.Write ($"- четные числа между 1 и {number}");  
}

