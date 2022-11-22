using System;
using static System.Console;

Clear();
Write("Введите число A:");
int a=int.Parse(ReadLine());
Write("Введите число B:");
int b=int.Parse(ReadLine());

int step = Pow(a,b);
WriteLine($"A в степпени В = {step}");

int Pow(int x, int y)
{
    if(y==0)
    {
        return 1;

    }
    int result =x;
    for(int i=2; i<=y; i++)
    {
        result*=x;
    }
    return result;
}