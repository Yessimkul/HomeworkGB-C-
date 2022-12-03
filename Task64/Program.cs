using System;
using static System.Console;

Clear();

Write("Введите первое число :");
int m = int.Parse(ReadLine());
Write("Введите второе число :");
int n = int.Parse(ReadLine());

if (m>n)
{
    WriteLine(PrintNumber(n,m));
}
else
{
    WriteLine(PrintNumber(m,n));
}

string PrintNumber(int start, int end)
{
    if(end==start) return end.ToString();
    return(end+" "+PrintNumber(start,end-1));
}