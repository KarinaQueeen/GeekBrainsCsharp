// Программа
int[] array = {1, 2, 3, 4, 5, 6};

int n = array.Length;                                 // возвращает количество чисел в массиве

int find = 4;
int index = 0;

while(index<n)
{
    if (array [index]== find)
    {
        Console.WriteLine (index);
        break;                                        //при выполнении условия ПРЕРВАТЬ чтобы не вывел два числа если они одинаковые
    }
    index++;
}
