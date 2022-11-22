using System;
using static System.Console;

Clear();
int[] array = GetArray(10,100,999);
WriteLine(String.Join(" ",array));
int countEl=GetEwenElements(array);
WriteLine($"Количество четных элементов = {countEl}");

int GetEwenElements(int[] inArray)
{
    int count=0;
    foreach (var item in inArray)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

int[] GetArray(int size, int min, int max)
{
    int[] result=new int[size];
    for(int i=0; i<size; i++)
    {
        result[i] = new Random().Next(min,max+1);
    }
    return result;
}