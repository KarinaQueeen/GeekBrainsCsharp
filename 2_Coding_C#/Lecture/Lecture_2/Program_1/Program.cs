// Программа находит максимальное число

int a1 = 4;
int b1 = 5;
int c1 = 6;
int a2 = 2;
int b2 = 3;
int c2 = 1;
int a3 = 8;
int b3 = 15;
int c3 = 0;

int Max (int a, int b, int c)
{
    int maxi = a;
    if (b > maxi) maxi = b;
    if (c > maxi) maxi = c;
    return maxi;
}

int max = Max( Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));
Console.WriteLine (max);