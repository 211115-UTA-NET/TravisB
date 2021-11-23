// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int dummy = -10;
int second = -20;
bool testBoolean = true;

dummy++;
Console.WriteLine("Dummy's value is " + dummy);
dummy--;
Console.WriteLine("Dummy's value is " + dummy);
Console.WriteLine("The arithmetic inverse of dummy is " + -dummy);

Console.WriteLine(!testBoolean);
Console.WriteLine(dummy * second);
Console.WriteLine(second / dummy);
Console.WriteLine(dummy + second);
Console.WriteLine(dummy - second);
Console.WriteLine(second % dummy);

bool check1 = (dummy != 0) & (dummy > second);
Console.WriteLine(check1);
bool check2 = (dummy == second) | (dummy < 0);
Console.WriteLine(check2);