// Программа находит максимальное число массива

int [] array = new int [10]   
{10, 45, 23, 45, 65, 23 ,43, 56, 23, 23}; 

int max = array [0];
for (int i = 0; i< array.Length; i++)    
{
    if (array [i] > max)
    {
        max = array [i];
    }
}
Console.WriteLine(max);
