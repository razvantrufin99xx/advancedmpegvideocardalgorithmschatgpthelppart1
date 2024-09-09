Sure! Here's a simple example of how you can create and perform basic arithmetic operations with fractions in C# using a custom `Fraction` class:

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
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(3, 4);

        Fraction sum = f1 + f2;
        Fraction difference = f1 - f2;
        Fraction product = f1 * f2;
        Fraction quotient = f1 / f2;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
    }
}
```

This code defines a `Fraction` class with basic arithmetic operations (addition, subtraction, multiplication, and division) and a `Main` method to demonstrate these operations. You can expand this class with more features like reducing fractions to their simplest form or handling improper fractions.

Would you like to see more advanced features or have any specific requirements for your fraction math?

Sursă: conversație cu Copilot. 9/9/2024
(1) ahotko/MathExtended.Fractions: Fractions Library for C# - GitHub. https://github.com/ahotko/MathExtended.Fractions.
(2) Fractions 8.0.4 - NuGet Gallery. https://www.nuget.org/packages/Fractions/.
(3) Fraction Class C#. Supports formatting, comparing and simplifying .... https://gist.github.com/fidelsoto/b4c0f14b800c58e137ad5757f35cacd6.
(4) GitHub - alexkarate/Fractions: A simple fraction library for C#. https://github.com/alexkarate/Fractions.
(5) Assist with fractions in C# - CodeProject. https://www.codeproject.com/Questions/1175398/Assist-with-fractions-in-Csharp.
(6) Math.NET Symbolics. https://symbolics.mathdotnet.com/.
(7) github.com. https://github.com/zsx/ossbuild/tree/a510b4fb1b15922c14dd6311a24f139b8a790699/Main%2FGStreamer%2FSource%2Fgstreamer-sharp%2Fgstreamer-sharp%2FValue.cs.
(8) github.com. https://github.com/ANYAPESHKO/Labs/tree/e714b3fc375f965dd1d93ac11f1ecaf8124b565b/7Lab%2FFraction.cs.