using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, a, b, r, odleglosc;
        a = 0;
        b = 0;
        Console.WriteLine("Podaj wsp�rz�dne punktu P (x, y)");
        x = inputValue();
        y = inputValue();
        Console.WriteLine("Podaj promie� ko�a (r)");
        r = inputValue();
        odleglosc = (x - a) * (x - a) + (y - b) * (y - b);
        if (odleglosc <= r * r)
        {
            Console.Write("Punkt P le�y w obr�bie ko�a o �rodku O (");
            Console.Write(a);
            Console.Write(" , ");
            Console.Write(b);
            Console.WriteLine(")");
        }
        else
        {
            Console.Write("Punkt P NIE le�y w obr�bie ko�a o �rodku O(");
            Console.Write(a);
            Console.Write(" , ");
            Console.Write(b);
            Console.WriteLine(")");
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
