using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;
        Console.WriteLine("Podaj liczbê naturaln¹: ");
        a = inputValue();
        b = a % 10;
        Console.Write("Ostatnia cyfra Twojej liczby to: ");
        Console.WriteLine(b);
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
