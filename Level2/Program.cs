using System;

namespace Level2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            N1();
        }

        private static void N1()
        {
            double x = 1;
            double s = 0;
            int i = 1;

            while (true)
            {
                double a = Math.Cos(i * x) / Math.Pow(i, 2);
                if (Math.Abs(a) < 0.0001)
                {
                    break;
                }
                s += a;
                i++;
            }
            Console.WriteLine(s);
        }

        private static void N2()
        {
            int n = 1;
            int p = 1;
            do
            {
                n += 3;
                p *= n;

            } while (p <= 30000);
            Console.WriteLine(n - 3);
        }

        private static void N3()
        {
            int s = 0;
            int a = 2;
            int h = 3;
            int i = 0;
            int p = 300;

            while (true)
            {
                s += (a + i * h);
                if (s > p)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i);
        }

        private static void N4()
        {
            int i = 0;
            double s = 0;
            double x = 0.5;
            while (true)
            {
                double a = Math.Pow(x, 2 * i);
                if (a < 0.0001)
                {
                    break;
                }
                s += a;
                i++;
            }
            Console.WriteLine(s);
        }

        private static void N5()
        {
            int n = 433;
            int m = 3;
            int chast = 0;
            int ostat = 0;

            while (true)
            {
                if (n - m >= 0)
                {
                    n -= m;
                    chast++;
                }
                else
                {
                    ostat = n;
                    break;
                }
            }

            Console.WriteLine($"N: {n}; M: {m}; Частное: {chast}; Остаток: {ostat};");
        }

        private static void N7_8()
        {
            double x = 10;
            double sum = 0;
            int i = 0;
            bool b = false;
            while (true)
            {
                i++;
                sum += x;
                x *= 1.1;

                if (i == 7)
                {
                    Console.WriteLine($"a) {sum}");
                }
                if (sum >= 100 && !b)
                {
                    Console.WriteLine($"б) {i}");
                    b = true;
                }
                if (x > 20)
                {
                    Console.WriteLine($"в) {i}");
                    break;
                }
            }
        }

        private static void N9()
        {
            double x = 10000;
            int i = 0;
            while (true)
            {

                x *= 1.08;
                i++;
                if (x >= 20000)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}