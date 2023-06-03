using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a;
        int b;
        int c;
        int d;
        int x;
        int y;
        Console.WriteLine("Wpisz kolejno 4 liczby ca³kowite (a/b+c/d)");
        a = (int)inputValue();
        b = (int)inputValue();
        c = (int)inputValue();
        d = (int)inputValue();
        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwi¹zania!");
        }
        else
        {
            x = a * d + b * c;
            y = b * d;
            Console.Write("Licznik (x) wynosi: ");
            Console.WriteLine(x);
            Console.Write("Mianownik (y) wynosi: ");
            Console.WriteLine(y);
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
