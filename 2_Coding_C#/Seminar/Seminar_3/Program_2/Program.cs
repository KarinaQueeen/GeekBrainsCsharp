// Программа выдает в какой четверти плоскости координат находится точка (x,y), с координатами которые вводит пользователь

/*
 2   |   1
_____|_____
     |
 3   |   4
*/

int Metod (int x, int y)
{
    if (x>0 && y>0) return 1;
    if (x>0 && y<0) return 2;
    if (x<0 && y<0) return 3;
    if (x<0 && y>0) return 4;
    return 0;
}

Console.Write ("Введите координату x: ");
int x = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Введите координату y: ");
int y = Convert.ToInt32 (Console.ReadLine ());

int number = Metod (x,y);

Console.Write ($"Точка с координатами ({x}, {y}) находится в {number} четверти.");