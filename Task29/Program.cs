using System;
using static System.Console;

Clear();
WriteLine($"[{String.Join(",",GetRandomArray(8))}]");

int[] GetRandomArray(int size)
{
    int[] result=new int[size];
    for(int i=0; i<size;i++)
    {
        result[i]=new Random().Next(100);
    }
    return result;
}