// Программа выводит второую цифру у трехзначного числа

Console.Write ("Введите трехзначное число: ");
int [] array = {int.Parse(Console.ReadLine())};

//??????????

int size = array.length;
int index = 0;
int secondIndex = 1;
while (index <size)

if (array [index] == secondIndex)

Console.WriteLine($"{array [index]} вторая цифра числа {array}.");
index++;


else
Console.WriteLine($"Число {array} не трехзначное.");
