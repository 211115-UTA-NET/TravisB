// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n;

for (n=1; n<=1000; n++)
{
    if (n%15 == 0)
    {
        Console.WriteLine("Fizz-Buzz");
    }
    else if (n%5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (n%3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else Console.WriteLine(n);
}