using System.Runtime.CompilerServices;

public static class Adder
{
    public static int Add(int a, int b)
    {
        Console.WriteLine("adding integers");
        return a + b;
    }

    [OverloadResolutionPriority(1)]
    public static double Add(double a, double b)
    {
        Console.WriteLine("adding doubles");
        return a + b;
    }
}