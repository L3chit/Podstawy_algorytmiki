using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Wprowadz wartosc pierwsza");
        a = inputValue();
        Console.WriteLine("Wprowadz wartosc druga");
        b = inputValue();
        Console.WriteLine("Wprowadz wartosc trzecia");
        c = inputValue();
        double sredniaArytmetyczna;

        sredniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine(sredniaArytmetyczna);
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
