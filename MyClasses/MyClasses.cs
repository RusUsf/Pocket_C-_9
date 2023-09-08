
namespace MyClasses;
public class UnitConverter
{
    int ratio; // Field
    public UnitConverter(int unitRatio)
    {
        ratio = unitRatio;
    }
    public int Convert(int unit) // Method
    {
        return unit * ratio;
    }
}

public class Panda
{
    public string Name;              // Instance field
    public static int Population;    // Static field

    public Panda(string n)           // Constructor
    {
        Name = n;                    // Instance field
        Population = Population + 1; // Static field
    }
}

public struct PointStruct { public int X, Y; }
public class PointClass { public int X, Y; }

public class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }
}

public class School
{
    public static string? Name = "Swain High School";
    public string? Principal;
}

public class Car
{
    public string? Model { get; set; }
    public int Speed { get; set; }
    public Car(string model)
    {
        Model = model;
        Speed = 0;
    }
}

public class MyMonkeyFoo
{
    System.Text.StringBuilder sb;
    public MyMonkeyFoo(string initialValue)
    {
        sb = new(initialValue);
    }
    public void PrintValue()
    {
        Console.WriteLine(sb);
    }
}

