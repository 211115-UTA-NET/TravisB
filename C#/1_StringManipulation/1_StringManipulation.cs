string inputString;
int number;
string userNumber;

Console.WriteLine("Please enter your message and press enter");
inputString = Console.ReadLine();
Console.WriteLine("Please enter a number LESS THAN the length of your message and press enter");
userNumber = Console.ReadLine();
number = int.Parse(userNumber);
Console.WriteLine(inputString);
Console.WriteLine(number);
char myChar;

Console.WriteLine("For which character should I search your original message?");
myChar = char.Parse(Console.ReadLine());

bool searchChar = inputString.Contains(myChar);
if (searchChar)
{
    Console.WriteLine("Your message does indeed contain the character " + myChar);
}
else
{
    Console.WriteLine("Your message did not contain the character " + myChar);
}