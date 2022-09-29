// Программа переводит число из десятичной в двоичную систему

Console.Write("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine ());

Console.Write($"Число {a} в двоичной системе = ");

string b = "";
while (a != 0)
{
   b += Convert.ToString (a % 2);
   a = a / 2;
}
for (int i = 0; i < b.Length; i++)
{
    Console.Write(b[b.Length - 1 - i]);
}

