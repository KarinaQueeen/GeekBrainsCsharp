Console.WriteLine("Введите целое число: ");
try
    {
        int a = Convert.ToInt32 (Console.ReadLine ());
        Console.WriteLine($"Отлично, {a} целое число!");
        int b = a * a;
        Console.WriteLine($"Квадрат {a} = {b}."); 
    }

catch
    {
        Console.WriteLine("Неверный ввод."); 
    }