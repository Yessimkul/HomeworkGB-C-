Console.Clear();
Console.Write("Введите число:");
int n=int.Parse(Console.ReadLine());

if(n<100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}


int a = (n/100)%10;

Console.WriteLine($"Третья цифра с конца числа {n} =  {a}");