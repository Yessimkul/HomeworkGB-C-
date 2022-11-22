Console.Clear();
Console.Write("Введите число N:");
int n=int.Parse(Console.ReadLine());
int i = 1;
while(i<=n)
{
    if(i%2 == 0)
    {
        Console.WriteLine($"{i}");
    }
    i++;
}
