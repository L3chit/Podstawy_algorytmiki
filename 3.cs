using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double waga;
        double wzrost;
        double bmi;
        Console.WriteLine("Podaj swoj¹ wagê w kilogramach");
        waga = inputValue();
        Console.WriteLine("Podaj swój wzrost w metrach");
        wzrost = inputValue();
        Console.Write("Twoje BMI wynosi: ");
        bmi = waga / (wzrost * wzrost);
        Console.Write(bmi);
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
