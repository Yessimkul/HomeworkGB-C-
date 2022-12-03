using System;
using static System.Console;

Clear();

Write("Введите количество строк :");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов :");
int n = int.Parse(ReadLine());


int[,] array = GetArray(m,n);
PrintArray(array);

Write("Введите значение переменной :");
int x = int.Parse(ReadLine());

if(FindElement(array,x))
{
    WriteLine("Элемент присутствует в массиве");
}
else
{
    WriteLine("Элемент не найден");
}

bool FindElement(int[,] elArray,int el)
{
    for(int i=0; i<elArray.GetLength(0); i++)
    {
        for(int j=0; j<elArray.GetLength(1); j++)
        {
             if(elArray[i,j]==el) return true;
        }
    }
    return false;
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