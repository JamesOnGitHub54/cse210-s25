using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that has one parameter for the top and that initializes the denominator to 1.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Create getters and setters for both the top and the bottom values.
    public void GetTop()
    {

    }

    public void SetTop(int top)
    {

    }

    public void GetBottom()
    {

    }

    public void SetBottom(int bottom)
    {

    }

    // Create a method called GetFractionString that returns the fraction in the form 3/4.
    public string GetFractionString()
    {
        return "";
    }

    // Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number.
    public double GetDecimalValue()
    {
        return 0;
    }
}