Console.WriteLine("Введите первое число");
string s1 = Console.ReadLine();
int a = int.Parse(s1);
Console.WriteLine("Введите второе число");
string s2 = Console.ReadLine();
int b = int.Parse(s2);
if (a / b == b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}