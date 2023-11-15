int n = int.Parse(Console.ReadLine());
int min = 100000000;

for (int i = 1; i <= n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number < min)
    {
        min = number;
    }
}
Console.WriteLine(min);