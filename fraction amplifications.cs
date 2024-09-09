To amplify fractions in C#, you can extend the `Fraction` class to include methods for raising fractions to a power and finding the reciprocal. Here's an updated version of the `Fraction` class with these additional features:

```csharp
using System;

public class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        Numerator = numerator;
        Denominator = denominator;
        Simplify();
    }

    private void Simplify()
    {
        int gcd = GCD(Numerator, Denominator);
        Numerator /= gcd;
        Denominator /= gcd;
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        return new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        return new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.Numerator == 0)
        {
            throw new DivideByZeroException("Cannot divide by a fraction with a numerator of zero.");
        }
        return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
    }

    public Fraction Reciprocal()
    {
        return new Fraction(Denominator, Numerator);
    }

    public Fraction Power(int exponent)
    {
        return new Fraction((int)Math.Pow(Numerator, exponent), (int)Math.Pow(Denominator, exponent));
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

class Program
{
    static void Main()
    {
        Fraction f1 = new Fraction(2, 3);
        Fraction f2 = new Fraction(3, 4);

        Fraction sum = f1 + f2;
        Fraction difference = f1 - f2;
        Fraction product = f1 * f2;
        Fraction quotient = f1 / f2;
        Fraction reciprocal = f1.Reciprocal();
        Fraction power = f1.Power(2);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Reciprocal: {reciprocal}");
        Console.WriteLine($"Power: {power}");
    }
}
```

In this code, the `Reciprocal` method returns the reciprocal of the fraction, and the `Power` method raises the fraction to a specified exponent. These methods enhance the functionality of the `Fraction` class, allowing for more complex mathematical operations.

Feel free to test this code and let me know if you need any further modifications or additional features!

Sursă: conversație cu Copilot. 9/9/2024
(1) Fraction Class C#. Supports formatting, comparing and simplifying .... https://gist.github.com/fidelsoto/b4c0f14b800c58e137ad5757f35cacd6.
(2) GitHub - alexkarate/Fractions: A simple fraction library for C#. https://github.com/alexkarate/Fractions.
(3) GitHub - danm-de/Fractions: A fraction data type to calculate with .... https://github.com/danm-de/Fractions.
(4) github.com. https://github.com/zsx/ossbuild/tree/a510b4fb1b15922c14dd6311a24f139b8a790699/Main%2FGStreamer%2FSource%2Fgstreamer-sharp%2Fgstreamer-sharp%2FValue.cs.
(5) github.com. https://github.com/ANYAPESHKO/Labs/tree/e714b3fc375f965dd1d93ac11f1ecaf8124b565b/7Lab%2FFraction.cs.