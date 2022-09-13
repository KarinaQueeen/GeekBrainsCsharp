//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int MetodSumNumbers (int num)
{
    num = Math.Abs (num);
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10; 
    }
    return sum;
}

try 
{
    Console.Write ("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int sum = MetodSumNumbers (number);
    Console.Write ($"Сумма всех цифр в числе {number} = {sum}");
}

catch
{
    Console.Write ("Ошибка: не верно введены данные.");
}
