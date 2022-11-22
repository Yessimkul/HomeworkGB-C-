using System;
using static System.Console;

Clear();
int[] array = GetArray(5,1,5);
WriteLine(String.Join(" ",array));
int sumOdd= GetSumOddPositions(array);
WriteLine($"Сумма элементов = {sumOdd}");

int GetSumOddPositions(int[] array)
{
    int sum=0;
    for (int i=0; i<array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
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