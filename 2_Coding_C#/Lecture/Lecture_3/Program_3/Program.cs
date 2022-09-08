// Программа меняет символы в тексте

string Metod (string text, char oldSim, char newSim)
{
    string result = string.Empty;
    int size = text.Length;

    for (int i = 0; i < size; i++)
    {
        if (text [i] == oldSim ) 
        result = result + $"{newSim}";
        else 
        result = result + $"{text[i]}";
    }
    return result;
}

string a = "В лесу родилась елочка.";

string b = Metod (a, ' ', '-');
string c = Metod (b, 'е', 'Е');
Console.WriteLine(c);