using System;
using static System.Console;

Clear();

Write("Введите числа через пробел:");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"Количество чисел больше 0 = {MoreThanZero(array)}");

int[] GetArrayFromString(string arrayString)
{
    string[] nums=arrayString.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int[] result=new int[nums.Length];
    for(int i=0; i<result.Length; i++)
    {
        result[i]= int.Parse(nums[i]);
    }
    return result;
}

int MoreThanZero(int[] InArray)
{
    int counter = 0;
    foreach(int item in InArray)
    {
        if(item>0) counter++;
    }
    return counter;
}