using System;
using static System.Console;

Clear();

int[] array = GetArray(6,1,99);
WriteLine(String.Join(" ",array));
int diff = GetDif(array);
WriteLine($"Разница между макс и мин = {diff}");


int GetDif(int[] MMarray)
{
    int result = 0;
    int max = MMarray[0];
    int min = MMarray[1];
    
    for(int i=0;i<MMarray.Length; i++)
    {
        if (MMarray[i]>max) {max=MMarray[i];}
        if (MMarray[i]<min) {min=MMarray[i];}
    }
    result = max - min;
    return result;
}   





int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i=0; i<size; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}