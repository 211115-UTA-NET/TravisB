// See https://aka.ms/new-console-template for more information
string input;
Console.WriteLine("Enter one from the following [yYnN]");
input = Console.ReadLine();
if (input == "y" || input == "Y")
{
    Console.WriteLine("YES");
}
else if (input == "n" || input == "N")
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("Not a valid character, please enter a character from among the following set y, Y, n, N");
}