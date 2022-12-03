using System;
using static System.Console;

Clear();

Write("Введите первое число :");
int m = int.Parse(ReadLine());
Write("Введите второе число :");
int n = int.Parse(ReadLine());

if (m>n)
{
    WriteLine(Sum(n,m));
}
else
{
    WriteLine(Sum(m,n));
}

int Sum(int start, int end)
{
    if(end==start) return start;

    return (end+Sum(start,end-1));
}