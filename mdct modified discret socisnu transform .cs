Sure! Here's a basic implementation of the Modified Discrete Cosine Transform (MDCT) in C#:

```csharp
using System;

public class MDCT
{
    private int N;
    private double[] cosTable;
    private double[] sinTable;

    public MDCT(int N)
    {
        this.N = N;
        cosTable = new double[N];
        sinTable = new double[N];

        for (int i = 0; i < N; i++)
        {
            cosTable[i] = Math.Cos(Math.PI / N * (i + 0.5));
            sinTable[i] = Math.Sin(Math.PI / N * (i + 0.5));
        }
    }

    public double[] Forward(double[] input)
    {
        int halfN = N / 2;
        double[] output = new double[halfN];

        for (int k = 0; k < halfN; k++)
        {
            double sum = 0.0;
            for (int n = 0; n < N; n++)
            {
                sum += input[n] * cosTable[(2 * n + 1 + N / 2) * (2 * k + 1) % (2 * N)];
            }
            output[k] = sum;
        }

        return output;
    }

    public double[] Inverse(double[] input)
    {
        int halfN = N / 2;
        double[] output = new double[N];

        for (int n = 0; n < N; n++)
        {
            double sum = 0.0;
            for (int k = 0; k < halfN; k++)
            {
                sum += input[k] * cosTable[(2 * n + 1 + N / 2) * (2 * k + 1) % (2 * N)];
            }
            output[n] = sum;
        }

        return output;
    }
}

class Program
{
    static void Main()
    {
        int N = 8; // Length of the MDCT
        double[] input = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };

        MDCT mdct = new MDCT(N);
        double[] transformed = mdct.Forward(input);
        double[] inverseTransformed = mdct.Inverse(transformed);

        Console.WriteLine("Transformed:");
        foreach (var value in transformed)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("Inverse Transformed:");
        foreach (var value in inverseTransformed)
        {
            Console.WriteLine(value);
        }
    }
}
```

This code provides a simple implementation of the Modified Discrete Cosine Transform (MDCT) and its inverse. The `Forward` method computes the MDCT of the input signal, while the `Inverse` method reconstructs the original signal from the MDCT coefficients.

Feel free to ask if you have any questions or need further assistance!

Sursă: conversație cu Copilot. 9/9/2024
(1) discrete-cosine-transform · GitHub Topics · GitHub. https://github.com/topics/discrete-cosine-transform.
(2) Modified discrete cosine transform - YouTube. https://www.youtube.com/watch?v=7jrKf5gVq-c.
(3) DCT Implementation in C# (DCT of Image) - CodeProject. https://www.codeproject.com/articles/43782/dct-implementation-in-c-dct-of-image.