using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;
        Console.WriteLine("Podaj dwie liczby");
        a = inputValue();
        b = inputValue();
        if (a > b)
        {
            Console.Write(a);
        }
        else
        {
            Console.Write(b);
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
