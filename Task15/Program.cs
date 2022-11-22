Console.Clear();
Console.Write("Введите день недели:");
int n=int.Parse(Console.ReadLine());

if(n<1 || n>7)
{
    Console.WriteLine("Такого дня недел не существует");
    return;
}
if(n<=5)
{
    Console.WriteLine("Это будний день");
}
else
{
    Console.WriteLine("Это выходной день");
}