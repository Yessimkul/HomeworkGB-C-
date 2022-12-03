using System;
using static System.Console;

Clear();

Write("Введите количество строк :");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов :");
int n = int.Parse(ReadLine());


int[,] array = GetArray(m,n);
PrintArray(array);


WriteLine($"Среднее арифметическое каждого столбца = {String.Join(";", FindAverage(array))}");


double[] FindAverage(int[,] elArray)
{
    double[] result = new double[elArray.GetLength(0)];
    
    for(int i=0; i<elArray.GetLength(0); i++)
    {
        double sum=0;
        for(int j=0; j<elArray.GetLength(1); j++)
        {
            sum+=elArray[j,i];
        }
        result[i] = sum/elArray.GetLength(0);
    }
    return result;
}


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
            result[i,j] = new Random().Next(1,100);
    }
    return result;

}