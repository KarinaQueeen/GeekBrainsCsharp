// Программа создает массив из случайных неповторяющихся чисел

bool SearchElem (int [] array, int a)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] == a)
        {
            return true;
        }
    }
    return false;
}

int [] array = new int [10];
for (int i = 0; i < array.Length; i++)
{
    bool flag = false;
    while (flag != true)
    {
        flag = false;
        int b = new Random().Next (1, 100);
        if (SearchElem (array, b))
        {
            continue;
        }
        else
        {
            array [i] = b;
            flag = true;
        }
    }
}

for (int i = 0; i < array.Length; i++) Console.Write (array [i] +" ");


