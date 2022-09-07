int [] array = new int [10]    //массив целых чисел из 10 элементов
{10, 45, 23, 45, 65, 23 ,43, 56, 23, 23}; // если не задали массив сразу, необходимо указывать его размер

                                            /*
                                            int a = array [2];
                                            Console.WriteLine(a);
                                            */

int max = array [0];
for (int i = 0; i< array.Length; i++)    //(начало цикла, счетчик, шаг)
    {
        if (array [i] > max)
            {
                max = array [i];
            }
    }
Console.WriteLine(max);
