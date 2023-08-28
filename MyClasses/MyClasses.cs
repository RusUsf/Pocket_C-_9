
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