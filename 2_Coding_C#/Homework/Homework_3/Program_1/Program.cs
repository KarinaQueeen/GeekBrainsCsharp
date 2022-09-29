// Программа проверяет является ли пятизначное число палиндромом

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number/10000 > 0 && number/10000<10)
{
    if (number/10000 == number%10)
    if (number/1000%10 == number/10%10)
    Console.WriteLine($"Число {number} палиндром");    
    else Console.WriteLine($"Число {number} не палиндром");
}
else Console.WriteLine($"Число {number} не пятизначное");


