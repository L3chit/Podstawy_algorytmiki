using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj boki tr�jk�ta (a, b, c):");
        double a, b, c;
        a = inputValue();
        b = inputValue();
        c = inputValue();
        if (a == b && b == c)
        {
            Console.WriteLine("Boki mog� utworzy� tr�jk�t r�wnoboczny");
        }
        else
        {
            Console.WriteLine("Boki NIE mog� utworzy� trojk�t r�wnoboczny");
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
