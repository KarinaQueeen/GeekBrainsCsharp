// Программа между дмуся точками находит расстояние в 3D пространстве

double Metod (int x1, int y1, int z1, int x2, int y2, int z2)
    {
        double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
        return result;
    }

Console.Write("Введите первую координату первой точки: ");
int x1 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите вторую координату первой точки: ");
int y1 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите первую координату второй точки: ");
int z1 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите первую координату второй точки: ");
int x2 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите вторую координату второй точки: ");
int y2 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите вторую координату второй точки: ");
int z2 = Convert.ToInt32 (Console.ReadLine ());

double result = Math.Round(Metod (x1, y1, z1, x2, y2, z2),2); 

Console.Write($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) состовляет {result}.");
