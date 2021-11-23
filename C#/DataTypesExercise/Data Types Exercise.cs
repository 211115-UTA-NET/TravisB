// See https://aka.ms/new-console-template for more information
byte newbyte = 14;
sbyte newsbyte = -62;
int newint = -243680;
uint newuint = 962;
short newshort = -16400;
ushort newushort = 627;
long newlong = 9559635936;
ulong newulong = 41856548526358;
float newfloat = 10.56f;
double newdouble = 456815853524105848.5484156874158;
char newchar = 'Y';
bool newboolean = true;
string newstring = "sting";
decimal newdecimal = -1998213696;

string string1 = "I control text";
string string2 = "42";

int number;
bool success = int.TryParse(string2, out number);
if (success)
{
    number = Int32.Parse(string2);
    Console.WriteLine("String2's numerical value is " +number);
}
else
{
    Console.WriteLine("This string could not be parsed to an integer");
}

Console.WriteLine("The byte value is " +newbyte);
Console.WriteLine("The sbyte value is " +newsbyte);
Console.WriteLine("The int value is " +newint);
Console.WriteLine("The uint value is " +newuint);
Console.WriteLine("The short value is " +newshort);
Console.WriteLine("The ushort value is " +newushort);
Console.WriteLine("The long value is " +newlong);
Console.WriteLine("The ulong value is " +newulong);
Console.WriteLine("The float value is " +newfloat);
Console.WriteLine("The double value is " +newdouble);
Console.WriteLine("The char value is " +newchar);
Console.WriteLine("The bool value is " +newboolean);
Console.WriteLine("The string value is " +newstring);
Console.WriteLine("The decimal value is " +newdecimal);
Console.WriteLine(string1);
