using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int number)
    {
        _numerator = number;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public string GetFraction()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    public double GetDecimal()
    {
        return (double)_numerator / (double)_denominator;
    }
}