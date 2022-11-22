Console.Clear();
Console.Write("Введите число:");
int n=int.Parse(Console.ReadLine());

if(n<10000 || n>99999)
{
    Console.WriteLine("Это не пятизначное число");
    return;
}

int a1 = n/10000;
n -= a1*10000;
int a2 = n/1000;
n -= a2*1000;
int a3 = n/100;
n -= a3*100;
int a4 = n/10;
int a5 = n%10;

if((a1==a5)&&(a2==a4))
{
    Console.WriteLine ("Число является полиндромом");
}
else
{
  Console.WriteLine ("Число не является полиндромом");  
}