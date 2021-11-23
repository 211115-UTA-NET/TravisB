string testString = "abcdefghijklmnopqrstuvwxyz";
Console.WriteLine(testString);
//Read individual characters
Console.WriteLine("############## Individual Character ##############");
char myChar = testString[0];
Console.WriteLine(myChar);

//Find the length of a string of characters
Console.WriteLine("############## Length ##############");
Console.WriteLine(testString.Length);


/*Concatenation -n. a series of interconnected things or events
line up or join multiple strings one after another */
 
string one = "This is a string";

string two = "This is a different string";

Console.WriteLine( one + " " + two );


Console.WriteLine(one);
Console.WriteLine(two);


//Change cases to upper case, or lower case
Console.WriteLine("############## Case Change ##############");
Console.WriteLine(testString.ToUpper());


//Change the case of specific letters in a string

//Trim start, trim end, trim
Console.WriteLine("############## Trim ##############");
string badSpacing = "         Hello          World          ";
Console.WriteLine(badSpacing);
Console.WriteLine("start " + badSpacing + "end");
Console.WriteLine("start " + badSpacing.TrimStart() + " end");
Console.WriteLine("start " + badSpacing.TrimEnd() +" end");
Console.WriteLine("start " + badSpacing.Trim() + " end");


//Portions of strings
Console.WriteLine("############## Substrings ##############");
string betterSpacing = "hello world";
Console.WriteLine(betterSpacing.Substring(6));