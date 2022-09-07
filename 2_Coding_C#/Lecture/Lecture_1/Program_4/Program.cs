int count = 0; //счетчик
while (count <100) // количество раз в цикле
{
count ++;
}

Console.Clear (); // очистка терминала
Console.SetCursorPosition (10, 4); // для отступов от левого и верхнего
Console.WriteLine ("+");


int xa = 1;
int ya = 1;
int xb = 1;
int yb = 30;
                    /* 
                        также можно записать в одну строку
                        int xa = 1, ya = 1, xb = 1, yb = 30, xc = 80, yc = 30;
                    */
Console.SetCursorPosition (xa, ya);
Console.WriteLine ("+");
Console.SetCursorPosition (xb, yb);
Console.WriteLine ("+");
Console.SetCursorPosition (xc, yc);
Console.WriteLine ("+");
