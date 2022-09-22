/* Двумерные массивы
string [,] table = new string [2,3];
таблица с 2 строками и 3 столбцами

table [0,0] table [0,1] table [0,2]
table [1,0] table [1,1] table [1,2]

int [,] matrix = new int [5,8];
матрица из 5 строк и 8 столбцов
0 0 0 0 0 0 0 0
0 0 0 0 0 0 0 0
0 0 0 0 0 0 0 0
0 0 0 0 0 0 0 0
0 0 0 0 0 0 0 0
*/

/*
string [,] table = new string [2,5];
table [1,2] = "слово";

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
       Console.WriteLine ($"*{table[i,j]}*");
    }
}
*/

int [,] matrix = new int [3,4];
for (int i = 0; i < matrix.GetLength(0); i++)    // matrix.GetLength(0) показывает количество строк из заданного массива / matrix.GetLength(1) - количество столбцов
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write ($"{matrix[i,j]} ");      // пробел для вывода чисел в строку через пробел, можно использовать (\t) табуляцию
    }
    Console.WriteLine();                        // переход на новую строку, когда цикл прошелся по всей строке
}


