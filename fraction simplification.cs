Sure! Here's an updated version of the `Fraction` class that includes a method to simplify fractions:

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

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

class Program
{
    static void Main()
    {
        Fraction f1 = new Fraction(4, 8);
        Fraction f2 = new Fraction(10, 20);

        Console.WriteLine($"Fraction 1: {f1}");
        Console.WriteLine($"Fraction 2: {f2}");
    }
}
```

In this code, the `Simplify` method reduces the fraction to its simplest form by dividing both the numerator and the denominator by their greatest common divisor (GCD). The `GCD` method uses the Euclidean algorithm to find the greatest common divisor.

Feel free to test this code and let me know if you need any further modifications or additional features!

Sursă: conversație cu Copilot. 9/9/2024
(1) Reduce the fraction to its lowest form - GeeksforGeeks. https://www.geeksforgeeks.org/reduce-the-fraction-to-its-lowest-form/.
(2) ahotko/MathExtended.Fractions: Fractions Library for C# - GitHub. https://github.com/ahotko/MathExtended.Fractions.
(3) GitHub - alexkarate/Fractions: A simple fraction library for C#. https://github.com/alexkarate/Fractions.
(4) Fraction Reduce | C# Online Compiler | .NET Fiddle. https://dotnetfiddle.net/nBzr0i.
(5) Fraction Class C#. Supports formatting, comparing and simplifying .... https://gist.github.com/fidelsoto/b4c0f14b800c58e137ad5757f35cacd6.