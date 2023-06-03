using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wartości x i y:");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == 1 || x == -1){
            if (y == 0){
                Console.WriteLine("Wynik: 1,0");
            }else{
                Console.WriteLine("Wynik: -1,0");
            }
        }else if (x == -2 || x == 2){
            if (y == 0){
                Console.WriteLine("Wynik: -2,0");
            }else{
                Console.WriteLine("Wynik: 2,0");
            }
        }else{
            Console.WriteLine("Wynik: " + x + "," + y);
        }
    }
}
