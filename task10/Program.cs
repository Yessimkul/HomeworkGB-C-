Console.Clear();
Console.Write("Введите число:");
int n=int.Parse(Console.ReadLine());

int n2 = (n / 10) % 10;
Console.WriteLine($"{n} -> {n2}");
