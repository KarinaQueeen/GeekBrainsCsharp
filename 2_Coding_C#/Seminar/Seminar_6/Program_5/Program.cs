// Программа выводит числа Фибоначи

int Fibonacci (int n)
{
   if (n==0) 
    {
      return 0; 
    }   
     if (n==1) 
    {
      return 1; 
    }        
     if (n==2) 
    {
      return 1; 
    }                
    else 
    {
      n = (n-1) + (n-2);
    
    return n;

    }
}

for (int i = 0; i < 15; i++)
{
   Console.Write ($"{Fibonacci(i)} ");
}
// ???

