// Программа выводит массив из 8 элементов заполненный 0 и 1 в случайном порядке

int [] NewArray ()
{
  int [] array = new int [8];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random ().Next (0,2);
  }
  return array;
}

void PrintArray (int [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write (array [i]);  
  }      
}

int [] array = NewArray ();
PrintArray (array);