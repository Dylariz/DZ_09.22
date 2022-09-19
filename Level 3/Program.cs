using System;

namespace Level_3
{
    internal class Program
    {
        public static void Main(string[] args) // №1
        {
            for (double x = 0.1; x <= 1; x += 0.1)
            {
                double s = 0;
                int i = 0;
                
                while (true)
                {
                    double a = 0;

                    a = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Factorial(2 * i);
                    
                    if (Math.Abs(a) < 0.0001)
                    {
                        break;
                    }

                    s += a;
                    i++;
                }
                Console.WriteLine($"X: {x}; S: {s};  Y: {Math.Cos(x)};  Last i: {i};");
            }
        }

        static int Factorial(int x)
        {
            int s = 1;
            for (int i = 2; i <= x; i++)
            {
                s *= i;
            }

            return s;
        }
    }
}