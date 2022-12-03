using System;
using static System.Console;

Clear();

Write("Введите значение M :");
int m = int.Parse(ReadLine());
Write("Введите значение N :");
int n = int.Parse(ReadLine());

WriteLine($"Функция Аккермана  = {Akkerman(m,n)}");


int Akkerman(int x, int y)
{
    if(x==0) return y+1;
    if(y==0) return Akkerman(x-1,1);
    return Akkerman(x-1, Akkerman(x,y-1));
}