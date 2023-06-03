using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj boki trójk¹ta (a, b, c):");
        double a, b, c;
        a = inputValue();
        b = inputValue();
        c = inputValue();
        if (a == b && b == c)
        {
            Console.WriteLine("Boki mog¹ utworzyæ trójk¹t równoboczny");
        }
        else
        {
            Console.WriteLine("Boki NIE mog¹ utworzyæ trojk¹t równoboczny");
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
