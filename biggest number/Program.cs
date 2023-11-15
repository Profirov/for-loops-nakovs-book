int n = int.Parse(Console.ReadLine());
int max = -100000000;

for (int i = 1; i <= n; i++)
{ 
   int number = int.Parse(Console.ReadLine());
    if (number > max)
    { 
      max = number;
    }
}
Console.WriteLine(max);