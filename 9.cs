using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Podaj wartoœci zmiennych a, b i c:");
        a = inputValue();
        b = inputValue();
        c = inputValue();
        b = b + a;
        a = b - a;
        b = b - a;
        c = a + c;
        a = c - a;
        c = c - a;
        Console.WriteLine("Po zamianie miejscami: ");
        Console.Write("a= ");
        Console.WriteLine(a);
        Console.Write("b= ");
        Console.WriteLine(b);
        Console.Write("c= ");
        Console.WriteLine(c);
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
