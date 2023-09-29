//using System.Collections.Generic;
//using System;
//using System.Diagnostics.Metrics;
//using MyClasses;

//Console.WriteLine(FeetToInches(30));
//Console.WriteLine(FeetToInches(100));


//// Feet to Inches method
//int FeetToInches(int feet)
//{
//    int inches = feet * 12;
//    return inches;
//}


//// Method with no return type
//SayHello();
//void SayHello()
//{
//    Console.WriteLine("Coding Pro-Tip: Read, Do, Read, Do, Read, Do!");
//}

//string message = "Do not give up after first failure!";
//string upperMessage = message.ToUpper();
//Console.WriteLine(upperMessage);

//bool simpleVar = false;
//if (simpleVar)
//    Console.WriteLine("This will not print.");
//if (!simpleVar)
//    Console.WriteLine("This will print.");

//int x = 5000;
//bool lessThanAMile = x < 5280;
//if (lessThanAMile)
//    Console.WriteLine("Celebrate Small Accomplishments!");


//// Custom Types p.9
//UnitConverter feetToInches = new UnitConverter(12);
//UnitConverter milesToFeet = new UnitConverter(5280);

//Console.WriteLine(feetToInches.Convert(30));
//Console.WriteLine(milesToFeet.Convert(100));
//Console.WriteLine(feetToInches.Convert(milesToFeet.Convert(1)));


//// Instance versus Static memeber p.11
//Panda pandaOne = new Panda("Pan Dee");
//Panda pandaTwo = new Panda("Pan Dah");
//Panda pandaThree = new Panda("Pan Rah");

//Console.WriteLine(pandaOne.Name);
//Console.WriteLine(pandaTwo.Name);
//Console.WriteLine(pandaThree.Name);
//Console.WriteLine(Panda.Population); // 3


//// Type and Conversions p.14
//int xX = 12345;        // int is a 32-bit integer
//long yY = xX;         // Implicit conversion to 64-bit int
//short zZ = (short)xX; // Explicit conversion to 16-bit int

//// Value Types

//PointStruct pointOne = new PointStruct();
//pointOne.X = 7;

//PointStruct pointTwo = pointOne;   // Assigment causes copy

//Console.WriteLine(pointOne.X); // 7
//Console.WriteLine(pointTwo.X); // 7

//pointOne.X = 9;             // Change pointOne.X

//Console.WriteLine(pointOne.X); // 9
//Console.WriteLine(pointTwo.X); // 7

//// Reference Type
//PointClass pointClassOne = new PointClass();
//pointClassOne.X = 7;

//PointClass pointClassTwo = pointClassOne; // Copies reference

//Console.WriteLine(pointClassOne.X); // 7
//Console.WriteLine(pointClassTwo.X); // 7

//pointClassOne.X = 9;                // Change pointClassOne.X
//Console.WriteLine(pointClassOne.X); // 9
//Console.WriteLine(pointClassTwo.X); // 9

//// Nullable Value Type

//int? i = null;
//Console.WriteLine(i == null);             // True

////Struct
//Nullable<int> iI = new Nullable<int>();
//Console.WriteLine(!iI.HasValue);        // True

//// Nullable Reference Type
//var myString = "Retrieve from memory!";
//Foo(myString);
//void Foo(string? s)
//{
//    // Safe guard for NullReferenceException
//    if (s != null) Console.WriteLine(s.Length);
//    if (s != null) Console.WriteLine(s);
//}

//// Numeric suffixes F & M                               p.21
//float f = 4.5F;     // Won't compile without suffix
//decimal d = -1.23M; // Won't compile without suffix

//// Numeric Conversions
//int myX = 12345;        // int is a 32-bit integral type
//long myY = myX;         // Implicit conversion to 64-bit int
//short myZ = (short)myX; // Explicit conversion to 16-bit int

//Console.WriteLine($"{f.GetType()}, {f}, {d.GetType()}, {d}, {myX.GetType()}, {myX}, {myY.GetType()}, {myY}, {myZ.GetType()}, {myZ}");

//// Increment and Decrement Operators                    p.22
//int myInt = 0;
//Console.WriteLine(myInt++);  // Outputs 0; myInt is now 1
//Console.WriteLine(++myInt);  // Outpust 2; myInt is now 2
//Console.WriteLine(--myInt);  // Outputs 1; myInt is now 1

////var myVar = myX / 0;         // Run-time error (a DivideByZeroException)

//var myVar1 = 0;
//var myVar2 = myVar1 / 5;
//Console.WriteLine(myVar2);

//// Overflow
//int a = int.MinValue; a--;
//Console.WriteLine(a == int.MaxValue); // True

//// Cehcked operator
//int aA = 1000000, bB = 10000000;

//// Checks just the expression
////int c = checked(aA * bB);              // OverflowException

//// Checks all expressions in block           
////checked {var c = a * bB; }             // OverflowException

//// 8- and 16-Bit Integral Types                         p.24
//short myX2 = 1, myY2 = 1;
////short myZ2 = myX2 + myY2;              // Compile-time error

//short myZ2 = (short)(myX2 + myX2);          // Explicit conversion to short
//Console.WriteLine($"{myZ2.GetType()}, {myZ2}");

//var myZ3 = myX2 + myY2;                  // Imlicit conversion to Int
//Console.WriteLine($"{myZ3.GetType()}, {myZ3}");

//// Equality and Comparison Operators                    p.27
//int myX3 = 1, myY3 = 2, myzZ = 1;
//Console.WriteLine(myX3 == myY3);        // False
//Console.WriteLine(myX3 == myzZ);        // True

//// Conditional Operators                                p.27
//bool myWind = false;
//bool myRain = true;
//bool mySun = false;

//Console.WriteLine($"Use Umbrella today? {UseUmbrella(myRain, mySun, myWind)}");                           // True

//static bool UseUmbrella(bool rainy, bool sunny, bool windy)
//{
//    return !windy && (rainy || sunny);
//}

//// Ternary conditional operator q ? a : b
//static int Max(int a, int b)
//{
//    return (a > b) ? a : b;
//}

//Console.WriteLine(Max(3, 7));     // 7

//// String and Characters
//char c = 'A';
//Console.WriteLine(c); // A

//// String Types
//string myStringA = "Do not expect immediate results.";
//Console.WriteLine($"{myStringA.GetType()}, {myStringA}");

//string myStringB = "Celebrate small accomplishments!";
//Console.WriteLine(myStringA == myStringB);  //False

//// Escape Character \
//string myFilePathA = "\\C:\\Users\\rus_d\\OneDrive\\DesktopBackup\\Hobbies\\Learn to Code forever\\Coding Books\\C#\\Pocket_CS_9\r\n";

//// Verbatim string literals - @                 p.30
//string myFilePathB = @"C:\Users\rus_d\OneDrive\DesktopBackup\Hobbies\Learn to Code forever\Coding Books\C#\Pocket_CS_9";

//Console.WriteLine(myFilePathA == myFilePathB);  //False

//// String interpolation
//int myTwo = 2;
//string myStringTwo = $@"this spans {myTwo} lines";
//Console.WriteLine(myStringTwo);

//// String Comparisons
//Console.WriteLine("Ruslan".CompareTo("Anthony")); // 1
//Console.WriteLine("Ruslan".CompareTo("Ruslan"));  // 0
//Console.WriteLine("Ruslan".CompareTo("Zoe"));    // -1

//// Searching within strings                     p.32

//Console.WriteLine("Ruslan"[2]);                 // s
//Console.WriteLine("Ruslan".Contains("Rusl"));   // True
//Console.WriteLine("Ruslan".StartsWith("Rus"));  // True
//Console.WriteLine("Ruslan".EndsWith("lan"));    // True

//// Manipulating strings
//string myQuote = "Adopt growth mindset - belief in the ability to learn and transform!";
//Console.WriteLine(myQuote.Substring(7));
//Console.WriteLine(myQuote.Insert(0, "Learning Tip: "));
//Console.WriteLine(myQuote.Remove(myQuote.Length - 1));
//Console.WriteLine(myQuote.ToUpper());


//// Arrays                                       p.32
//char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
//Console.WriteLine(vowels[1]);     // e

//// Method I to print values of the Array
//Console.WriteLine(string.Join(", ", vowels));

//// Method II to print values of the Array
//int counter = 0;
//foreach (var item in vowels)
//{
//    counter++;
//    Console.Write(item);
//    if (counter != vowels.Length)
//    {
//        Console.Write(", ");
//    }
//}

//Console.WriteLine("\npress [enter] to continue...");
//Console.Read();

//// Method III 
//foreach (char vowel in vowels) Console.Write(vowel + ", ");

////Console.WriteLine(vowels[10]);//IndexOutOfRangeException

//Console.WriteLine("\npress [enter] to continue...");
//Console.Read();

//string[] cities = { "Tampa", "Sarasota", "St.Petersburg" };
//Console.WriteLine(string.Join(" ,", cities));

//// Simplified Array Initialization Expressions
//void Fooo(char[] data) { Console.WriteLine(data); };           // Method Fooo
//Fooo(new char[] { 'a', 'b', 'c' });                           // Longhand
//Fooo(new[] { 'a', 'b', 'c' });                                // Shortcut

//// Variables and Parameters                                   p.38

//// Stack
//static int Factorial(int x)
//{
//    if (x == 0) return 1;
//    return x * Factorial(x - 1);
//}

//var results = Factorial(3);
//Console.WriteLine(results);

//// Static vs not static Method

//// Accessing Static method Add()
//var myResultsAdd = Calculator.Add(2, 3);
//Console.WriteLine(myResultsAdd);

//// Accessing not Static method Multiply()
//Calculator myCalculator = new Calculator();
//var myResultsMultiply = myCalculator.Multiply(5, 5);
//Console.WriteLine(myResultsMultiply);

//// Accessing Static property
//var mySchoolName = School.Name;
//Console.WriteLine(mySchoolName);

//// Accessing non-Static property
//School mySchoolPrincipal = new School();
//var mySchoolPrincipalName = mySchoolPrincipal.Principal = "Ruslan Dubas";
//Console.WriteLine(mySchoolPrincipalName);

//// Constructors Examples
//Car myCar = new Car("Ferrari");
//Console.WriteLine(myCar.Model);
//myCar.Speed = 100;
//Console.WriteLine(myCar.Speed);

//// Default Values                                   p.40
//bool b = default;
//Console.WriteLine(b);
//int @int = default;
//Console.WriteLine(@int);
//string @string = default;
//Console.WriteLine(@string);
//bool @bool = @string == null;
//Console.WriteLine(@bool);

//// Passing arguments by value

//using MyClasses;
//using System.Text;

//int myInt2 = 8;
//Monkey(myInt2);           // Make a copy of MyInt2
//Console.WriteLine(myInt2);// myInt2 still be 8

//static void Monkey(int p)
//{
//    p = p + 1;
//    Console.WriteLine(p);
//}

//StringBuilder sb = new StringBuilder();
//MonkeyOne(sb);
//Console.WriteLine(sb.ToString());

//static void MonkeyOne(StringBuilder monkeySB)
//{
//    monkeySB.Append("test");
//    monkeySB = null;
//}

//// The ref modifier p.42
//int myXTwo = 8;
//MonkeyTwo(ref myXTwo);
//Console.WriteLine(myXTwo);

//static void MonkeyTwo(ref int p)
//{
//    p = p + 1;
//    Console.WriteLine(p);
//}

//// The out modifier
//int.TryParse("123", out int x);
//Console.WriteLine(x);

////SomeBigMethod(out _, out _, out int x, out _, out _);
////Console.WriteLine(x);

//// The params modifier
//int Sum(params int[] ints)
//{
//    int sum = 0;
//    for (int i = 0; i < ints.Length; i++) sum += ints[i];
//    return sum;
//}

//Console.WriteLine(Sum(1, 2, 3, 4));  // 10
//Console.WriteLine(Sum(new int[] { 1, 2, 3, 4 })); // 10

//// Optional Parameters
//void MonkeyThree(int x = 23) { Console.WriteLine(x); }
//MonkeyThree();

//MonkeyFour(1);
//void MonkeyFour(int x = 0, int y = 0)
//{
//    Console.WriteLine(x + ", " + y);
//}

//// Named arguments p.45
//MonkeyFour(x: 1, y: 2);
//MonkeyFour(y: 2, x: 1);

//// Optioanl & Named arguments
//Bar(d: 3);
//void Bar(int a = 0, int b = 0, int c = 0, int d = 0)
//{
//    Console.Write(a + ", " + b + ", " + c + ", " + d);
//}

//// var - Implicitly Typed Local Variables
//var name = "Ruslan Dubas";
//var myString = new System.Text.StringBuilder();
//var myFloat = (float)Math.PI;

//// Target-Typed new Expressions
//StringBuilder sb1 = new();
//StringBuilder sb2 = new("Test");

//// same as StringBuilder sb1 = new StringBuilder();
//// same as StringBuilder sb2 = new StringBuilder();

//MyMethodFoo(new("\ntest"));
//void MyMethodFoo(System.Text.StringBuilder sb)
//{
//    Console.WriteLine(sb);
//}

//// Expressins and Operators

//// Null-Coalescing Operator
//string s1 = null;
//string s2 = s1 ?? "nothing"; // s2 evaluates to "nothing"
//Console.WriteLine(s2);

//// myVariable ??= someDefault;
//// if (myVariable == null) myVariable = someDefault;

//// Null-Conditional Operator or "Elvis" operator
//System.Text.StringBuilder sb3 = null;
//string s3 = sb3?.ToString(); // No error, s3 is null
//// same as
//string s4 = (sb3 == null ? null : sb3.ToString());
//Console.WriteLine(s4 = s4 ?? "nothing again");

//System.Text.StringBuilder sb5 = null;
//string s5 = sb5?.ToString().ToUpper();  // No error
//Console.WriteLine(s5 = s5 ?? "Nothing again and again!");

////x?.y?.z

//// same as 
////x == null ? null : (x.y == null ? null : x.y.z)

//System.Text.StringBuilder sb6 = new StringBuilder();
//var sb7 = sb6?.Append("Do not expect immediate results!");
//Console.WriteLine(sb7);

//StringBuilder sb8 = null;
//string result = sb8?.ToString() ?? "Default Value";
//Console.WriteLine(result);

//int? length = sb7?.ToString().Length;
//Console.WriteLine(length);

//MyMonkeyFoo monkeyFive = new MyMonkeyFoo("Retrieve from memory!");

//monkeyFive?.PrintValue();

//MyMonkeyFoo? monkeySix = null;

//monkeySix?.PrintValue();

//// Statements  p.55

//// Declaration Statements
//bool rich = true, famous = false;
//const double c = 2.99792458E08;

//// Expression Statements
//string stringOne = "Coding pro-tip: Read, Do, Read, Do, Read, Do!";

//// Selection Statements
//if (5 < 2 * 3)
//    Console.WriteLine(stringOne);

//// Code block
//var myNumber = 5 > 6 ? 2 * 3 : 3;
//if (myNumber < 3)
//{
//    Console.WriteLine(stringOne);
//    Console.WriteLine(monkeyFive);
//}

//// The else clause
//if (rich == false)
//    Console.WriteLine("Embrace challenges!");
//else
//    if (famous == false)
//    Console.WriteLine("Celebrate small accomplishments!");

//// Changing the flow of execution
//if (true)
//    if (false)
//        Console.WriteLine(rich);
//    else
//        Console.WriteLine(famous);

//// Same as
//if (true)
//{
//    if (false)
//        Console.WriteLine(rich);
//    else
//        Console.WriteLine(famous);
//}

//// Moving the braces
//if (true)
//{
//    if (false)
//        Console.WriteLine();
//}
//else
//    Console.WriteLine(famous);  // does not execute

//// Else If
//var age = 37;

//if (age >= 37)
//    Console.WriteLine("You can be president");
//else if (age >= 21)
//    Console.WriteLine("You can drink!");
//else if (age >= 18)
//    Console.WriteLine("You can vote");
//else
//    Console.WriteLine("You can wait!");

//// The switch statement p.58
//static void ShowCard(int cardNumber)
//{
//    switch (cardNumber)
//    {
//        case 13:
//            Console.WriteLine("King");
//            break;
//        case 12:
//            Console.WriteLine("Queen");
//            break;
//        case 11:
//            Console.WriteLine("Jack");
//            break;
//        default:  // Any other cardNumber
//            Console.WriteLine(cardNumber);
//            break;
//    }
//}

//var cardNumber = 12;
//ShowCard(cardNumber);

//// One Value
//static void WhichCard(int cardNumber)
//{

//    switch (cardNumber)
//    {
//        case 13:
//        case 12:
//        case 11:
//            Console.WriteLine("Face card");
//            break;
//        default:
//            Console.WriteLine("Plain card");
//            break;

//    }
//}

//WhichCard(cardNumber);

//// Switching on types     p.59
//static void TellMeTheType(object x)
//{
//    switch (x)
//    {
//        case int i:
//            Console.WriteLine("It's an int!");
//            break;
//        case string s:
//            Console.WriteLine(s.Length); // We can use s
//            break;
//        case bool b when b == true:      // Fires when b is true
//            Console.WriteLine("True");
//            break;
//        case null:              // You can also switch on null
//            Console.WriteLine("null");
//            break;
//    }
//}

//var myVar = true;
//var myVarTwo = 5;
//int? myVarThree = null;
//var myVarFour = "Reflect on your learnings!";

//TellMeTheType(myVar);
//TellMeTheType(myVarTwo);
//TellMeTheType(myVarThree);
//TellMeTheType(myVarFour);

//List<object> myValues = new List<object>();
//myValues.Add(myVar);
//myValues.Add(myVarTwo);
//myValues.Add(myVarThree);
//myValues.Add(myVarFour);

//foreach (var item in myValues)
//{
//    TellMeTheType(item);
//}

//// Adding values to the list
//List<object> myVars = new List<object> { myVar, myVarTwo, myVarThree, myVarFour };

//foreach (var item in myVars)
//    TellMeTheType(item);

//// Switch expressions p.61
//int cardNumber = 11;
//string cardName = cardNumber switch
//{
//    13 => "King",
//    12 => "Queen",
//    11 => "Jack",
//    _ => "Pip card"
//};

//Console.WriteLine($"The cardName of cardNumber {cardNumber} is {cardName}");

//int cardNumber = 13; string suite = "spades";
//string cardName = (cardNumber, suite) switch
//{
//    (13, "spades") => "King of spades",
//    (13, "clubs") => "King of clubs",
//    _ => "Pip card"
//};

//Console.WriteLine($"The cardName of cardNumber {cardNumber} and suite {suite} is {cardName}");


//// Iteration Statements p.61

//// while 
//int i = 0;
//while (i < 3)
//    Console.WriteLine(i++);

//// do-while
//int j = 0;
//do
//{
//    Console.WriteLine(j++);
//}
//while (j < 3);

//// for loop
//for (int k = 0; k < 3; k++)
//    Console.WriteLine(k);

//// first 10 Fibonacci numbers p.62
//for (int z = 0, prevFib = 1, curFib = 1; z < 10; z++)
//{
//    Console.WriteLine(prevFib);
//    int newFib = prevFib + curFib;
//    prevFib = curFib; curFib = newFib;
//}

//// foreach loop           p.63
//foreach (var item in "Ruslan")
//    Console.Write(item +" ");

//List<object> list = new List<object> { "Rus", "Ruslan", "Roman" };

//foreach (var item in list)
//    Console.WriteLine(item+", ");

//Console.WriteLine(string.Join(", ",list));

//// p.64 Continue Statement
//for (int i = 0; i < 10; i++)
//{
//    if ((i % 2) == 0) continue;
//    Console.Write(i+" ");
//}

//// p.64 goto statement
//int j = 1;
//startLoop:
//if (j <= 5)
//{
//    Console.Write(j + " ");
//    j++;
//    goto startLoop;
//}

////p.64 return statement
//decimal d1 = 0.5m;

//Console.WriteLine(AsPercentage(d1));
//static decimal AsPercentage(decimal d)
//{
//    decimal p = d * 100m;
//    return p;
//}

////p.65 Namespaces
//using Outer.Middle.Inner;
//Class1 c;
//Outer.Middle.Inner.Innermost.Class1 c1;

//namespace Outer
//{
//    namespace Middle
//    {
//        namespace Inner
//        {
//            class Class1 { }
//            class Class2 { }
//        }
//    }
//}

//namespace Outer.Middle.Inner.Innermost
//{
//    class Class1 { }
//    class Class2 { }
//}

////p.66 using static
//using static System.Console;
//WriteLine("Coding Pro-Tip: Read, Do, Read, Do, Read, Do!");

////p.67 Name scoping
//namespace Outer
//{
//    class Class1 { }
//    namespace Inner
//    {
//        class Class2 : Class1 { }
//    }
//}

//namespace MyTradingCompany
//{
//    namespace Common
//    {
//        class ReportBase { }
//    }

//    namespace ManagemetnReporting
//    {
//        class SalesReport : Common.ReportBase { }
//    }
//}





























































































































