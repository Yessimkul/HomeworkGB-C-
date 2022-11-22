using System;
using static System.Console;

Clear();
Write("Введите число:");
WriteLine($" Сумма цифр в числе = {GetSumNumbers(int.Parse(ReadLine()))}");



int GetSumNumbers(int n)
{
    int sum = 0;
    while(n>0)
    {
        sum +=n%10;
        n /=10;
    }
    return sum;
}