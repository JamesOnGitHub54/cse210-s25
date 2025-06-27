using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fractions:\n");

        // Creating fractions with different constructors.
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        // Testing Setters.
        fraction1.SetTop(6);
        fraction2.SetTop(2);
        fraction2.SetBottom(4);
        fraction3.SetBottom(8);

        // Testing Getters.
        Console.Write(fraction1.GetTop());
        Console.Write("/");
        Console.WriteLine(fraction1.GetBottom());

        Console.Write(fraction2.GetTop());
        Console.Write("/");
        Console.WriteLine(fraction2.GetBottom());

        Console.Write(fraction3.GetTop());
        Console.Write("/");
        Console.WriteLine(fraction3.GetBottom());
    }
}