Console.Clear();
Console.Write("Введите число:");
int n=int.Parse(Console.ReadLine());

if(n % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}