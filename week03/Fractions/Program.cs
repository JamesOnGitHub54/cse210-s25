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
        // Fraction 4 from assignment sample output.
        Fraction fraction4 = new Fraction(1, 3);

        // Setting fractions to match assignment sample output.
        fraction2.SetTop(5);
        fraction3.SetTop(3);
        fraction3.SetBottom(4);

        // Testing methods
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());





        /**     Commenting out previous tests to test for assignment sample output.
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
                                **/
    }
}