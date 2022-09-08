// Программа по двум точкам показывает расстояние между ними в 2D пространстве

double Metod (int x1, int y1, int x2, int y2)
    {
        double result = Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2));   // Math.Sqrt квадратный корень и Math.Pow возведение в квадрат
        return result;
    }

Console.Write("Введите первую координату первой точки: ");
int x1 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите вторую координату первой точки: ");
int y1 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите первую координату второй точки: ");
int x2 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите вторую координату второй точки: ");
int y2 = Convert.ToInt32 (Console.ReadLine ());

double result = Math.Round(Metod (x1, y1, x2, y2),3); // Math.Round указывает количество символов после запятой
                                                      // MidpointRounding.ToNegativeInfinity соглашение об округлении в меньшую сторону (обрезание)
Console.Write($"Расстояние между точками({x1}, {y1}) и ({x2}, {y2}) состовляет {result}.");

