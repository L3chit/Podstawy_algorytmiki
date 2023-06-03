using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;
        int c;
        Console.WriteLine("Podaj pierwsz¹ liczbê: ");
        a = inputValue();
        Console.WriteLine("Podaj drug¹ liczbê: ");
        b = inputValue();
        Console.WriteLine("Podaj numer dzia³ania: dodawanie(1), odejmowanie(2), mno¿enie(3) oraz dzielenie(4)");
        c = (int)inputValue();
        if (c == 1)
        {
            Console.WriteLine(a + b);
        }
        else
        {
            if (c == 2)
            {
                Console.WriteLine(a - b);
            }
            else
            {
                if (c == 3)
                {
                    Console.WriteLine(a * b);
                }
                else
                {
                    if (c == 4)
                    {
                        if (b == 0)
                        {
                            Console.Write(a);
                            Console.Write("/");
                            Console.WriteLine(b);
                        }
                        else
                        {
                            Console.WriteLine(a / b);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wybierz poprawne dzia³anie!");
                    }
                }
            }
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
