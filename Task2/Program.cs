Console.Clear();
Console.Write("Введите число а:");
int a=int.Parse(Console.ReadLine());
Console.Write("Введите число b:");
int b=int.Parse(Console.ReadLine());

if(a>b)
{
Console.WriteLine("a=max, b=min");
}
if(a==b)
{
    Console.WriteLine("a равно b");
}
else
{
    Console.WriteLine("a=min, b=max");
}
