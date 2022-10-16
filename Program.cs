using System;
using System.Collections.Generic;

namespace Derivative_calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateDerivative(2, 5, 3, 50);
        }

        private static float CalculateDerivative(float c, float x, float n, float factorial)
        {
            if (factorial == 0 || c == 0) return c * x;
            float newValue = c * MathF.Pow(x, n);
            Console.WriteLine(newValue);
            CalculateDerivative(c * n, x, n - 1, factorial - 1);
            return newValue;
        }
    }
}
