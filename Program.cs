using System;
using MyClasses;

Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100));


// Feet to Inches method
int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}


// Method with no return type
SayHello();
void SayHello()
{
    Console.WriteLine("Coding Pro-Tip: Read, Do, Read, Do, Read, Do!");
}

string message = "Do not give up after first failure!";
string upperMessage = message.ToUpper();
Console.WriteLine(upperMessage);

bool simpleVar = false;
if (simpleVar)
    Console.WriteLine("This will not print.");
if (!simpleVar)
    Console.WriteLine("This will print.");

int x = 5000;
bool lessThanAMile = x < 5280;
if (lessThanAMile)
    Console.WriteLine("Celebrate Small Accomplishments!");


// Custom Types p.9
UnitConverter feetToInches = new UnitConverter(12);
UnitConverter milesToFeet = new UnitConverter(5280);

Console.WriteLine(feetToInches.Convert(30));
Console.WriteLine(milesToFeet.Convert(100));
Console.WriteLine(feetToInches.Convert(milesToFeet.Convert(1)));


// Instance versus Static memeber p.11
Panda pandaOne = new Panda("Pan Dee");
Panda pandaTwo = new Panda("Pan Dah");
Panda pandaThree = new Panda("Pan Rah");

Console.WriteLine(pandaOne.Name);
Console.WriteLine(pandaTwo.Name);
Console.WriteLine(pandaThree.Name);
Console.WriteLine(Panda.Population); // 3


// Type and Conversions p.14
int xX = 12345;        // int is a 32-bit integer
long yY = xX;         // Implicit conversion to 64-bit int
short zZ = (short)xX; // Explicit conversion to 16-bit int

// Value Types

PointStruct pointOne = new PointStruct();
pointOne.X = 7;

PointStruct pointTwo = pointOne;   // Assigment causes copy

Console.WriteLine(pointOne.X); // 7
Console.WriteLine(pointTwo.X); // 7

pointOne.X = 9;             // Change pointOne.X

Console.WriteLine(pointOne.X); // 9
Console.WriteLine(pointTwo.X); // 7

// Reference Type















