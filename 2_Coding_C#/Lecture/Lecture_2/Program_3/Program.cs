void FillArray (int [] collection)      //аргумент коллекция   воид метод не возвращает аргументы
{
int length = collection.Length;  //длина массива
int index = 0;
while (index<length)
{
    collection [index] = new Random ().Next(1,10);    // обратиться в колекцию и положить туда случайное число от 1 до 9
    index++;
}
}
void PrintArray (int [] col)
{
int count = col.Length; 
int position = 0;
while (position<count)
{
    Console.WriteLine (col [position] );  
    position++;
}
}

int IndexOf (int [] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = -1;
  while (index < count)
  {
    if (collection [index]==find)
    {
        position = index;
        break;
    }
    index++;
  }
  return position;
  
}

int [] array = new int [10];       //создать новый массив из 10 чисел

FillArray (array);            
PrintArray (array);

Console.WriteLine ("---");
int pos = IndexOf(array, 4);
Console.WriteLine (pos);