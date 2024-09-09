Sure! Here's a simple example of how you can perform numerical integration in C# using the Simpson's Rule. This method is useful for approximating the integral of a function.

```csharp
using System;

class Program
{
    static void Main()
    {
        // Define the function to integrate
        Func<double, double> function = x => x * x;

        // Define the integration limits
        double a = 0.0;
        double b = 10.0;

        // Number of intervals (must be even)
        int n = 1000;

        // Calculate the integral
        double result = SimpsonRule(function, a, b, n);

        Console.WriteLine($"The integral result is: {result}");
    }

    static double SimpsonRule(Func<double, double> f, double a, double b, int n)
    {
        if (n % 2 != 0)
        {
            throw new ArgumentException("Number of intervals must be even.");
        }

        double h = (b - a) / n;
        double sum = f(a) + f(b);

        for (int i = 1; i < n; i += 2)
        {
            sum += 4 * f(a + i * h);
        }

        for (int i = 2; i < n - 1; i += 2)
        {
            sum += 2 * f(a + i * h);
        }

        return sum * h / 3.0;
    }
}
```

This code defines a function \( f(x) = x^2 \) and calculates its integral from 0 to 10 using Simpson's Rule with 1000 intervals. You can modify the function and the limits as needed.

Would you like more details on numerical integration methods or any other specific topic?

Sursă: conversație cu Copilot. 9/9/2024
(1) Integral Calculator - Symbolab. https://www.symbolab.com/solver/integral-calculator.
(2) Numerical Integration - MathDotNet. https://numerics.mathdotnet.com/Integration.
(3) Math.NET Symbolics. https://symbolics.mathdotnet.com/.
(4) MathGPT | AI Math Solver & Calculator. https://math-gpt.org/.
(5) integral-equations · GitHub Topics · GitHub. https://github.com/topics/integral-equations.
(6) github.com. https://github.com/haeusser/PHYS242/tree/13422ca9f4817edd7615c0d4cf24c36c1b94abcf/HW02%2Fproblem02.java.
(7) github.com. https://github.com/haeusser/PHYS242/tree/13422ca9f4817edd7615c0d4cf24c36c1b94abcf/HW02%2Fproblem03.java.