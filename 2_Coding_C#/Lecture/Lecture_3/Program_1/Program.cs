// 1 метод (не принимает / не возвращает)

void Method1 ()
{
    Console.WriteLine("Автор ...");
}

Method1 ();    // вызывается метод со скобками


// 2 метод (принимает / не возвращает)

void Method2_1 (string a)
{
    Console.WriteLine (a);
}

Method2_1 ("Текст");

void Method2_2 (string a, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(a);
        i++;
    }
}

Method2_2 ("Текст", 3);   // ("Текст", 3) или (a: "Текст", count: 3) или (count: 3, a: "Текст")

// 3 метод (не принимает / возвращает)

int Method3 ()
{
    return DateTime.Now.Year;
}

int year = Method3 ();
Console.WriteLine(year);

//4 метод (принимает / возвращает)

string Method4_1 (int count, string text)
{
    int i = 0;
    string result = String.Empty;  //пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string a = Method4_1 (10, "текст");
Console.WriteLine(a);

string Method4_2 (int count, string text)
{
    string result = String.Empty; 
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string с = Method4_2 (10, "текст");
Console.WriteLine(с);


