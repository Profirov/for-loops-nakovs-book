int n = int.Parse(Console.ReadLine());
int oddSum = 0;
int evenSum = 0;

for (int i = 0; i < n; i++)
{
    int element = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        evenSum += element;
    }
    else
    { 
       oddSum += element;
    }
    
}
if (oddSum == evenSum)
{
    Console.Write("Yes");
    Console.WriteLine( oddSum);
}
else
{
    int different = Math.Abs(evenSum - oddSum);
    Console.Write("No");
    Console.WriteLine(different);
}