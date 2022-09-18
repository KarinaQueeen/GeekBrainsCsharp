// Программа проверяет может ли быть треугольник с такими сторонами

bool Triangle (int a, int b, int c)
{
    if (a<b+c && b<c+a && c<a+b)

    return false;
    else return true;
}

Console.Write("Введите размер 1 стороны треугольника: ");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите размер 2 стороны треугольника: ");
int b = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите размер 3 стороны треугольника: ");
int c = Convert.ToInt32 (Console.ReadLine ());
bool abc = Triangle (a, b, c);
Console.WriteLine(abc);


//
//\jjklp[;]