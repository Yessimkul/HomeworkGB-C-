using System;
using static System.Console;

Clear();

Write("Введите количество строк m:");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов n:");
int n = int.Parse(ReadLine());

int[,] array = GetArray(m,n);
PrintArray(array);

void PrintArray(int [,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine(" ");
    }
}



int[,] GetArray(int x, int y)
{
    int[,] result = new int [x,y];
    for(int i=0; i<result.GetLength(0); i++)
    {
        for(int j=0; j<result.GetLength(1); j++)
            result[i,j] = new Random().Next(1,10);
    }
    return result;

}