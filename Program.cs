using System;
using System.Diagnostics.Metrics;
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
PointClass pointClassOne = new PointClass();
pointClassOne.X = 7;

PointClass pointClassTwo = pointClassOne; // Copies reference

Console.WriteLine(pointClassOne.X); // 7
Console.WriteLine(pointClassTwo.X); // 7

pointClassOne.X = 9;                // Change pointClassOne.X
Console.WriteLine(pointClassOne.X); // 9
Console.WriteLine(pointClassTwo.X); // 9

// Nullable Value Type

int? i = null;
Console.WriteLine(i == null);             // True

//Struct
Nullable<int> iI = new Nullable<int>();
Console.WriteLine(!iI.HasValue);        // True

// Nullable Reference Type
var myString = "Retrieve from memory!";
Foo(myString);
void Foo(string? s)
{
    // Safe guard for NullReferenceException
    if (s != null) Console.WriteLine(s.Length);
    if (s != null) Console.WriteLine(s);
}

// Numeric suffixes F & M                               p.21
float f = 4.5F;     // Won't compile without suffix
decimal d = -1.23M; // Won't compile without suffix

// Numeric Conversions
int myX = 12345;        // int is a 32-bit integral type
long myY = myX;         // Implicit conversion to 64-bit int
short myZ = (short)myX; // Explicit conversion to 16-bit int

Console.WriteLine($"{f.GetType()}, {f}, {d.GetType()}, {d}, {myX.GetType()}, {myX}, {myY.GetType()}, {myY}, {myZ.GetType()}, {myZ}");

// Increment and Decrement Operators                    p.22
int myInt = 0;
Console.WriteLine(myInt++);  // Outputs 0; myInt is now 1
Console.WriteLine(++myInt);  // Outpust 2; myInt is now 2
Console.WriteLine(--myInt);  // Outputs 1; myInt is now 1

//var myVar = myX / 0;         // Run-time error (a DivideByZeroException)

var myVar1 = 0;
var myVar2 = myVar1 / 5;
Console.WriteLine(myVar2);

// Overflow
int a = int.MinValue; a--;
Console.WriteLine(a == int.MaxValue); // True

// Cehcked operator
int aA = 1000000, bB = 10000000;

// Checks just the expression
//int c = checked(aA * bB);              // OverflowException

// Checks all expressions in block           
//checked {var c = a * bB; }             // OverflowException

// 8- and 16-Bit Integral Types                         p.24
short myX2 = 1, myY2 = 1;
//short myZ2 = myX2 + myY2;              // Compile-time error

short myZ2 = (short)(myX2 + myX2);          // Explicit conversion to short
Console.WriteLine($"{myZ2.GetType()}, {myZ2}");

var myZ3 = myX2 + myY2;                  // Imlicit conversion to Int
Console.WriteLine($"{myZ3.GetType()}, {myZ3}");

// Equality and Comparison Operators                    p.27
int myX3 = 1, myY3 = 2, myzZ = 1;
Console.WriteLine(myX3 == myY3);        // False
Console.WriteLine(myX3 == myzZ);        // True

// Conditional Operators                                p.27
bool myWind = false;
bool myRain = true;
bool mySun = false;

Console.WriteLine($"Use Umbrella today? {UseUmbrella(myRain, mySun, myWind)}");                           // True

static bool UseUmbrella(bool rainy, bool sunny, bool windy)
{
    return !windy && (rainy || sunny);
}

// Ternary conditional operator q ? a : b
static int Max(int a, int b)
{
    return (a > b) ? a : b;
}

Console.WriteLine(Max(3, 7));     // 7

// String and Characters
char c = 'A';
Console.WriteLine(c); // A

// String Types
string myStringA = "Do not expect immediate results.";
Console.WriteLine($"{myStringA.GetType()}, {myStringA}");

string myStringB = "Celebrate small accomplishments!";
Console.WriteLine(myStringA == myStringB);  //False

// Escape Character \
string myFilePathA = "\\C:\\Users\\rus_d\\OneDrive\\DesktopBackup\\Hobbies\\Learn to Code forever\\Coding Books\\C#\\Pocket_CS_9\r\n";

// Verbatim string literals - @                 p.30
string myFilePathB = @"C:\Users\rus_d\OneDrive\DesktopBackup\Hobbies\Learn to Code forever\Coding Books\C#\Pocket_CS_9";

Console.WriteLine(myFilePathA == myFilePathB);  //False

// String interpolation
int myTwo = 2;
string myStringTwo = $@"this spans {myTwo} lines";
Console.WriteLine(myStringTwo);

// String Comparisons
Console.WriteLine("Ruslan".CompareTo("Anthony")); // 1
Console.WriteLine("Ruslan".CompareTo("Ruslan"));  // 0
Console.WriteLine("Ruslan".CompareTo("Zoe"));    // -1

// Searching within strings                     p.32

Console.WriteLine("Ruslan"[2]);                 // s
Console.WriteLine("Ruslan".Contains("Rusl"));   // True
Console.WriteLine("Ruslan".StartsWith("Rus"));  // True
Console.WriteLine("Ruslan".EndsWith("lan"));    // True

// Manipulating strings
string myQuote = "Adopt growth mindset - belief in the ability to learn and transform!";
Console.WriteLine(myQuote.Substring(7));
Console.WriteLine(myQuote.Insert(0, "Learning Tip: "));
Console.WriteLine(myQuote.Remove(myQuote.Length - 1));
Console.WriteLine(myQuote.ToUpper());


// Arrays                                       p.32
char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
Console.WriteLine(vowels[1]);     // e

// Method I to print values of the Array
Console.WriteLine(string.Join(", ",vowels));

// Method II to print values of the Array
int counter = 0;
foreach (var item in vowels)
{
    counter++;
    Console.Write(item);
    if (counter != vowels.Length)
    {
        Console.Write(", ");
    }
}

Console.WriteLine("\npress [enter] to continue...");
Console.Read();

// Method III 
foreach (char vowel in vowels) Console.Write(vowel+", ");

//Console.WriteLine(vowels[10]);//IndexOutOfRangeException

Console.WriteLine("\npress [enter] to continue...");
Console.Read();

string[] cities = { "Tampa", "Sarasota", "St.Petersburg" };
Console.WriteLine(string.Join(" ,",cities));











































