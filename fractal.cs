Sure! Here's a simple example of a fractal generator in C# that creates the Mandelbrot set. This code uses the `System.Drawing` library to generate and save the fractal image:

```csharp
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        int width = 800;
        int height = 800;
        Bitmap bitmap = new Bitmap(width, height);

        double xmin = -2.5;
        double xmax = 1.5;
        double ymin = -2.0;
        double ymax = 2.0;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                double a = xmin + (xmax - xmin) * x / width;
                double b = ymin + (ymax - ymin) * y / height;

                Complex c = new Complex(a, b);
                Complex z = new Complex(0, 0);

                int iterations = 0;
                int maxIterations = 1000;

                while (iterations < maxIterations && z.MagnitudeSquared() < 4.0)
                {
                    z = z * z + c;
                    iterations++;
                }

                Color color = iterations == maxIterations ? Color.Black : Color.FromArgb(255, iterations % 256, iterations % 256, iterations % 256);
                bitmap.SetPixel(x, y, color);
            }
        }

        bitmap.Save("mandelbrot.png");
        Console.WriteLine("Fractal image saved as mandelbrot.png");
    }
}

struct Complex
{
    public double Real { get; }
    public double Imaginary { get; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    public static Complex operator *(Complex c1, Complex c2)
    {
        return new Complex(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary, c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
    }

    public double MagnitudeSquared()
    {
        return Real * Real + Imaginary * Imaginary;
    }
}
```

This code generates an image of the Mandelbrot set and saves it as `mandelbrot.png`. You can adjust the parameters such as the image size, the region of the complex plane, and the maximum number of iterations to explore different parts of the fractal.

Feel free to ask if you need more details or have any other questions!

Sursă: conversație cu Copilot. 9/9/2024
(1) GitHub - franckydoo/fractalGenerator: C# .NET Core Fractal Generator .... https://github.com/franckydoo/fractalGenerator.
(2) GitHub - Zyn3/FractalGenerator: Fractal Generator is a C# console .... https://github.com/Zyn3/FractalGenerator.
(3) GitHub - ThomasJackDalby/fractal-generator: A C# console based .... https://github.com/ThomasJackDalby/fractal-generator.
(4) undefined. https://github.com/franckydoo/fractalGenerator.git.
(5) github.com. https://github.com/devxbasit/Learn-C--Programming---Marius-Bancila/tree/47fd3fd650b70b69567b25e1518e99ff1c714e40/OperatorOverloading.cs.
(6) github.com. https://github.com/zigorrom/FANS/tree/ae662f5944fe537bcbac8469dfd6497ac0a9ef7c/FANS%2Fclasses%2FData%20Handling%2FFFT.cs.
(7) github.com. https://github.com/florinrm/WorkshopDemo/tree/ef354948865b44b16d6194bf744115d1ec437621/DemoComplex%2FComplex.cs.