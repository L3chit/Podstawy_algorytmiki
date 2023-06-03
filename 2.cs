using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double pole;
        double promien;
        double obwod;
        Console.WriteLine("Podaj pole ko³a:");
        pole = inputValue();
        promien = Math.Sqrt(pole / Math.PI);
        obwod = 2 * Math.PI * promien;
        Console.Write("Obwod ko³a wynosi: ");
        Console.WriteLine(obwod);
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
