using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fractions:\n");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);
    }
}